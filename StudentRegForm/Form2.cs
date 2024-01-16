using Microsoft.VisualBasic;
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
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace StudentRegForm
{
    public partial class Form2 : Form
    {
        string strConnection = @"Data Source=AMIEL\SQLEXPRESS;Initial Catalog=student_db;Integrated Security=True";
        public Form2()
        {
            InitializeComponent();
        }

        int indexRow;
        private void Form2_Load(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(strConnection)) {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM students", sqlCon);
                DataTable dt = new DataTable();
                sqlDa.Fill(dt);
                dataGridView1.DataSource = dt;
            }           
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
            insert(textBox1.Text, textBox2.Text, textBox3.Text, comboBox1.SelectedItem.ToString(), dateTimePicker1.Value.ToString("yyyy-MM-dd"), comboBox2.SelectedItem.ToString());

            using (SqlConnection sqlCon = new SqlConnection(strConnection))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM students", sqlCon);
                DataTable dt = new DataTable();
                sqlDa.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }
        void insert(string LastName, string FirstName, string MiddleName, string Gender, string Date, string Program)
        {
            SqlConnection SqlConn = new SqlConnection(strConnection);
            string strSQL = "INSERT INTO students VALUES ('" + LastName + "', '" + FirstName + "', '" + MiddleName + "', '" + Gender + "', '" + Date + "', '" + Program + "');";
            SqlCommand sqlComd = new SqlCommand(strSQL, SqlConn);

            sqlComd.Connection.Open();
            sqlComd.ExecuteNonQuery();

            SqlConn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            delete(textBox1.Text);

            using (SqlConnection sqlCon = new SqlConnection(strConnection))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM students", sqlCon);
                DataTable dt = new DataTable();
                sqlDa.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }
        void delete(string LastName)
        {
            SqlConnection SqlConn = new SqlConnection(strConnection);
            string strSQL = "DELETE FROM students WHERE last_name = '"+ LastName + "';";
            SqlCommand sqlComd = new SqlCommand(strSQL, SqlConn);

            sqlComd.Connection.Open();
            sqlComd.ExecuteNonQuery();

            SqlConn.Close();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Form3 frm3 = new Form3();
            this.Hide();
            frm3.Show();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indexRow = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[indexRow];
            textBox1.Text = row.Cells[0].Value.ToString();
            textBox2.Text = row.Cells[1].Value.ToString();
            textBox3.Text = row.Cells[2].Value.ToString();
            comboBox1.Text = row.Cells[3].Value.ToString();
            dateTimePicker1.Text = row.Cells[4].Value.ToString();
            comboBox2.Text = row.Cells[5].Value.ToString();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            update(textBox1.Text, textBox2.Text, textBox3.Text, comboBox1.SelectedItem.ToString(), dateTimePicker1.Value.ToString("yyyy-MM-dd"), comboBox2.SelectedItem.ToString());

            using (SqlConnection sqlCon = new SqlConnection(strConnection))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM students", sqlCon);
                DataTable dt = new DataTable();
                sqlDa.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        void update (string LastName, string FirstName, string MiddleName, string Gender, string Date, string Program)
        {
            SqlConnection SqlConn = new SqlConnection(strConnection);
            string strSQL = "UPDATE students SET last_name = '"+LastName+"', first_name = '"+FirstName+"' WHERE last_name = '"+LastName+"';";
            SqlCommand sqlComd = new SqlCommand(strSQL, SqlConn);

            sqlComd.Connection.Open();
            sqlComd.ExecuteNonQuery();

            SqlConn.Close();
        }
    }
}
