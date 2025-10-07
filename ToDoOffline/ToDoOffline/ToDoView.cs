using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToDoOffline;

namespace TodoWin
{
    public partial class TodoView : Form
    {
        private List<ToDo> toDos = new List<ToDo>();

        public TodoView()
        {
            InitializeComponent();
            //ToDoListView.Columns.Clear();
            ToDoListView.Columns.Add("Title", 150);
            ToDoListView.Columns.Add("Body", 250);
            FetchToDos();
        }

        private void FetchToDos()
        {
            toDos = ToDoOfflineService.GetInstanse().GetAll();
            toDos.ForEach(td =>
            {
                var listViewItem = new ListViewItem(td.Title);
                listViewItem.SubItems.Add(td.Body);
                ToDoListView.Items.Add(listViewItem);
            });
        }

        private void TodoView_Load(object sender, EventArgs e)
        {

        }

        private void AddToDoButton_Click(object sender, EventArgs e)
        {
            new AddToDoForm().Show();
        }

        private void ToDoListView_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (ToDoListView.SelectedIndices.Count <= 0)
                return;
            int selectedIndex = ToDoListView.SelectedIndices[0];

            var x = ToDoListView.SelectedIndices.Count;
            var y = toDos.Count;



            new UpdateDeleteToDo(toDos[selectedIndex]).Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ToDoListView.Items.Clear();
            FetchToDos();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ToDoOfflineService.GetInstanse().SaveChanges();
        }
    }
}
