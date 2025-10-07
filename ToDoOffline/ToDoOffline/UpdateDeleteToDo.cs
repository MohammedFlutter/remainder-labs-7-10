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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace TodoWin
{
    public partial class UpdateDeleteToDo : Form
    {
        public UpdateDeleteToDo(ToDo toDo)
        {
            ToDo = toDo;
            InitializeComponent();
            TitleBox.Text = toDo.Title;
            BodyBox.Text = toDo.Body;
        }

        public ToDo ToDo { get; init; }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            var title = TitleBox.Text;
            var body = BodyBox.Text;
            if (string.IsNullOrEmpty(title))
            {
                MessageBox.Show("Title cannot be empty");
                return;
            }
            var updatedToDo = new ToDo
            {
                Id = ToDo.Id,
                Title = title,
                Body = body
            };
            ToDoOfflineService.GetInstanse().Update(updatedToDo);

            this.Close();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            ToDoOfflineService.GetInstanse().Delete(ToDo.Id);

            this.Close();

        }

        private void BodyBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
