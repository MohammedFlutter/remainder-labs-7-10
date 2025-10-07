using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfflineConsole
{
    public class ToDo
    {
        public ToDo() { }

        public static ToDo FromDataRow(DataRow row)
        {
            return new ToDo
            {
                Id = Convert.ToInt32(row["Id"]),
                Title = row["Title"].ToString(),
                Body = row["Body"].ToString()
            };
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }

        public override string ToString()
        {
            return $"Id: {Id}, Title: {Title}, Body: {Body}";
        }
    }
}
