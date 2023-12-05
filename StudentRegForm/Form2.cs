using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentRegForm
{
    public partial class Form2 : Form
    {
        public Form2()
        {

            InitializeComponent();
        }

        DataTable dt = new DataTable();

        private void Form2_Load(object sender, EventArgs e)
        {
            dt.Columns.Add("Last Name", typeof(string));
            dt.Columns.Add("First Name", typeof(string));
            dt.Columns.Add("Middle Name", typeof(string));
            dt.Columns.Add("Gender", typeof(string));
            dt.Columns.Add("Date", typeof(string));
            dt.Columns.Add("Program", typeof(string));




            string firstName = Form1.firstName;
            string lastName = Form1.lastName;
            string middleName = Form1.middleName;
            string gender = Form1.gender;
            string date = Form1.date;
            string program = Form1.program;

            dt.Rows.Add(firstName, lastName, middleName, gender, date, program);
            dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String firstNameForm2 = textBox1.Text;
            String lastNameForm2 = textBox2.Text;

            dt.Rows.Add(firstNameForm2, lastNameForm2);
            dataGridView1.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows.RemoveAt(rowIndex);
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            Form3 frm3 = new Form3();
            this.Hide();
            frm3.Show();
        }
    }
}
