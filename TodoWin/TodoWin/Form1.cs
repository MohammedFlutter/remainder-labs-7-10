using Microsoft.Data.SqlClient;
using System.Data;

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

            using (var sqlConnection = new SqlConnection(Strings.ConnectionString))
            {
                sqlConnection.Open();
                var sqlCommand = new SqlCommand("InsertToDo", sqlConnection);
                sqlCommand.CommandType =CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@Title", title);
                sqlCommand.Parameters.AddWithValue("@Body", body);
                sqlCommand.ExecuteNonQuery();
            }
            this.Close();
        }
    }
}
