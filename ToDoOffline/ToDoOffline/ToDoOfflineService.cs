using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoOffline
{
    public class ToDoOfflineService
    {
        private const string _connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ToDo_DB;Integrated Security=True";

        private static ToDoOfflineService? _toDoService;

        public static ToDoOfflineService GetInstanse()
        {
            if (_toDoService != null)
                return _toDoService;

            return _toDoService = new ToDoOfflineService();
        }
        private DataTable _dataTable;
        private SqlDataAdapter _adapter;

        private ToDoOfflineService()
        {
            SqlConnection connection = new SqlConnection(_connectionString);
            SqlCommand selectCommend = new SqlCommand("SELECT * FROM ToDo", connection);
            _adapter = new SqlDataAdapter(selectCommend);
            var commandBuilder = new SqlCommandBuilder(_adapter);
            _dataTable = new DataTable();
            _adapter.Fill(_dataTable);
            _dataTable.PrimaryKey = [_dataTable.Columns["id"]];

        }

        public List<ToDo> GetAll()
        {
            List<ToDo> toDos = [];
            foreach (DataRow row in _dataTable.Rows)
            {
                toDos.Add(ToDo.FromDataRow(row));
            }
            return toDos;
        }
        public void Add(ToDo toDo)
        {

            DataRow newRow = _dataTable.NewRow();
            newRow["Id"] = -1;
            newRow["Title"] = toDo.Title;
            newRow["Body"] = toDo.Body;
            _dataTable.Rows.Add(newRow);
        }


        public void Update(ToDo toDo)
        {

            DataRow? row = _dataTable.Rows.Find(toDo.Id);

            if (row != null)
            {
                row["Title"] = toDo.Title;
                row["Body"] = toDo.Body;
            }
        }
        public void Delete(int id)
        {
            DataRow? row = _dataTable.Rows.Find(id);
            if (row != null)
            {
                row.Delete();
            }
        }
        public void SaveChanges()
        {
            _adapter.Update(_dataTable);
        }



    }
}
