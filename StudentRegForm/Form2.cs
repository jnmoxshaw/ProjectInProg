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
        int indexRow;


        private void Form2_Load(object sender, EventArgs e)
        {
            string firstName = Form1.firstName;
            string lastName = Form1.lastName;
            string middleName = Form1.middleName;
            string gender = Form1.gender;
            string date = Form1.date;
            string program = Form1.program;

            dt.Columns.Add("Last Name", typeof(string));
            dt.Columns.Add("First Name", typeof(string));
            dt.Columns.Add("Middle Name", typeof(string));
            dt.Columns.Add("Gender", typeof(string));
            dt.Columns.Add("Date", typeof(string));
            dt.Columns.Add("Program", typeof(string));


            dt.Rows.Add(firstName, lastName, middleName, gender, date, program);
            dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string firstNameForm2 = textBox2.Text;
            string lastNameForm2 = textBox1.Text;
            string middleNameForm2 = textBox3.Text;
            string dateForm2 = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            Object selectedItem = comboBox1.SelectedItem;
            Object selectedItem2 = comboBox2.SelectedItem;

            string genderForm1 = selectedItem.ToString();
            string programForm2 = selectedItem2.ToString();

            dt.Rows.Add(firstNameForm2, lastNameForm2, middleNameForm2, genderForm1, dateForm2, programForm2);
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
            DataGridViewRow editRow = dataGridView1.Rows[indexRow];
            editRow.Cells[0].Value = textBox1.Text;
            editRow.Cells[1].Value = textBox2.Text;
            editRow.Cells[2].Value = textBox3.Text;
            editRow.Cells[3].Value = comboBox1.Text;
            editRow.Cells[4].Value = dateTimePicker1.Text;
            editRow.Cells[5].Value = comboBox2.Text;

        }
    }
}
