using Microsoft.Data.SqlClient;
using System.Data;
using ToDoOffline;

namespace TodoWin
{
    public partial class AddToDoForm : Form
    {
        public AddToDoForm()
        {
            InitializeComponent();
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ToDoForm_Load(object sender, EventArgs e)
        {

        }

        private void AddButton_Click(object sender, EventArgs e)
        {

            var title = TitleBox.Text;
            var body = BodyBox.Text;
            
            if (string.IsNullOrEmpty(title))
            {
                MessageBox.Show("Title cannot be empty");
                return;
            }
            var newToDo = new ToDo
            {
                Id=0,
                Title = title,
                Body = body
            };

            ToDoOfflineService.GetInstanse().Add(newToDo);
            this.Close();
        }
    }
}
