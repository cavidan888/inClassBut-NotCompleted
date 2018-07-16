using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bawir
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }


        public void finIdCat()
        {
            var connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\P106\Desktop\Bawir\Bawir\Schoolmdf.mdf;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connString);
            connection.Open();

            var selectQuery = "SELECT Id FROM Classes";


            var da = new SqlDataAdapter(selectQuery, connection);

            var ds = new DataSet();
            da.Fill(ds);
            comboBox1.Items.Clear();
            foreach (DataRow item in ds.Tables[0].Rows)
            {
                comboBox1.Items.Add(item["Id"]);
            }
            connection.Close();
        }


        private void btnShowTeacher_Click(object sender, EventArgs e)
        {
            var connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\P106\Desktop\Bawir\Bawir\Schoolmdf.mdf;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connString);
            connection.Open();

            var selectQuery = "SELECT * FROM Teachers";

            var da = new SqlDataAdapter(selectQuery, connection);

            var ds = new DataSet();
            da.Fill(ds);

            foreach (DataRow item in ds.Tables[0].Rows)
            {
                textBox1.Text += item["Id"] + "." + item["Name"] + "\r\n";
            }
            connection.Close();
        }

        private void btnStdeuntAdder_Click(object sender, EventArgs e)
        {
            var connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\P106\Desktop\Bawir\Bawir\Schoolmdf.mdf;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connString);
            connection.Open();

            var ClassesName = studName.Text;
            var ClassesStudentCount = int.Parse(studCount.Text);

            var insertQuery = "INSERT INTO Classes(Name,teacher_Id,studentCount) VALUES('" + ClassesName.ToString() + "' , '" + ClassesStudentCount.ToString() + "' , '" + comboBox1.SelectedItem.ToString() + "')";

            var insertCommand = new SqlCommand(insertQuery, connection);

            if (insertCommand.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("New Classes Added");
            }
            connection.Close();
        }

        private void btnShowStud_Click(object sender, EventArgs e)
        {
            var connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\P106\Desktop\Bawir\Bawir\Schoolmdf.mdf;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connString);
            connection.Open();

            var selectQuery = "SELECT * FROM Classes";

            var da = new SqlDataAdapter(selectQuery, connection);

            var ds = new DataSet();
            da.Fill(ds);

            foreach (DataRow item in ds.Tables[0].Rows)
            {
                textBox2.Text += item["Id"] + "." + item["Name"] + "." + item["teacher_Id"] + "." + item["studentCount"] + "\r\n";
            }
        }

        private void btnTeacherAdder_Click(object sender, EventArgs e)
        {
            var connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\P106\Desktop\Bawir\Bawir\Schoolmdf.mdf;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connString);
            connection.Open();

            var teacherName = teachName.Text;

            var insertQuery = "INSERT INTO Teachers(Name) VALUES('" + teacherName.ToString() + "')";


            var insertCommand = new SqlCommand(insertQuery, connection);

            if (insertCommand.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("New Teacher Added");
            }
            connection.Close();

            finIdCat();
        }
    }
}
