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

        public static DataTable dt = new DataTable();
        public Form2()
        {
            InitializeComponent();
            dataGridView1.DataSource = dt;

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
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

        private void registerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
