using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ADO_WF
{
    public partial class Form1 : Form
    {
        SqlConnection connection;
        public Form1()
        {
            InitializeComponent();
            //1.install Microsoft Data Sql Client Package
            //2.connection string
            string connection_string = "server = DESKTOP-97RM9E6\\SQLEXPRESS; Database = ITI; Trusted_Connection = true; TrustServerCertificate = true";
            //3.Create object of sql connection
            connection = new SqlConnection(connection_string);
            loaddata();
        }
        public void loaddata()
        {
            //4.Command
            string query = "select [Crs_Id], [Crs_Name], [Crs_Duration], [Top_Id] from [dbo].[Course];";
            SqlCommand command = new SqlCommand(query, connection);
            try
            {
                //5.open connection
                connection.Open();
                //6.Execution
                SqlDataReader reader = command.ExecuteReader();
                List<Course> courses = new List<Course>();
                while (reader.Read())
                {
                    Course course = new Course();
                    course.Id = reader.GetInt32(0);
                    course.Name = reader.GetString(1);
                    course.Duration = reader.GetInt32(2);
                    course.topic_id = reader.GetInt32(3);
                    courses.Add(course);
                }
                dataGridView1.DataSource = courses;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                //7.close connection
                connection.Close();
            }
        }
        private void btn_add_Click(object sender, EventArgs e)
        {
            int tmpid = int.Parse(textBox1.Text);
            string tmpname = textBox2.Text;
            int tmpduration = int.Parse(textBox3.Text);
            int tmptopid = int.Parse(textBox4.Text);

            //4.Command
            string query = $"INSERT INTO [dbo].[Course] ( [Crs_Id], [Crs_Name], [Crs_Duration], [Top_Id]) VALUES ({tmpid}, '{tmpname}', {tmpduration},{tmptopid});";
            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                //5.open connection
                connection.Open();
                //6.Execution
                int rows = command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                //7.close connection
                connection.Close();
                loaddata();
            }


        }
        private void btn_edit_Click(object sender, EventArgs e)
        {
            int tmpid = int.Parse(textBox1.Text);
            string tmpname = textBox2.Text;
            int tmpduration = int.Parse(textBox3.Text);
            int tmptopid = int.Parse(textBox4.Text);

            // 4. Command with parameterized query
            string query = "UPDATE [dbo].[Course] SET [Crs_Name] = @name, [Crs_Duration] = @duration, [Top_Id] = @topid WHERE [Crs_Id] = @id;";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@id", tmpid);
            command.Parameters.AddWithValue("@name", tmpname);
            command.Parameters.AddWithValue("@duration", tmpduration);
            command.Parameters.AddWithValue("@topid", tmptopid);

            try
            {
                // 5. Open connection
                connection.Open();
                // 6. Execution
                int rows = command.ExecuteNonQuery();
                MessageBox.Show($"{rows} row(s) updated.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                // 7. Close connection
                connection.Close();
                loaddata();
            }
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            textBox1.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void btn_delete_Click(object sender, EventArgs e) 
        {
            int tmpid = int.Parse(textBox1.Text);

            // 4. Command with parameterized query
            string query = "DELETE FROM [dbo].[Course] WHERE [Crs_Id] = @id;";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@id", tmpid);

            try
            {
                // 5. Open connection
                connection.Open();
                // 6. Execution
                int rows = command.ExecuteNonQuery();
                MessageBox.Show($"{rows} row(s) deleted.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                // 7. Close connection
                connection.Close();
                loaddata();
            }
        }
    }

    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Duration { get; set; }
        public int topic_id { get; set; }
    }

}
