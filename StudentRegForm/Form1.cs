using System.Data.SqlClient;
namespace StudentRegForm
{
    public partial class Form1 : Form
    {
        string strConnection = @"Data Source=AMIEL\SQLEXPRESS;Initial Catalog=student_db;Integrated Security=True";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
           insert(textBox3.Text, textBox1.Text, textBox2.Text, comboBox1.SelectedItem.ToString(), dateTimePicker1.Value.ToString("yyyy-MM-dd"), comboBox2.SelectedItem.ToString());

            this.Hide();
            Form3 frm2 = new Form3();
            frm2.Show();
        }

        void insert(string LastName, string FirstName, string MiddleName, string Gender, string Date, string Program)
        {
            SqlConnection SqlConn = new SqlConnection(strConnection);
            string strSQL = "INSERT INTO students VALUES ('" +LastName+ "', '"+FirstName+"', '"+MiddleName+"', '"+Gender+"', '"+Date+"', '"+Program+"');";
            SqlCommand sqlComd = new SqlCommand(strSQL, SqlConn);

            sqlComd.Connection.Open();
            sqlComd.ExecuteNonQuery();

            SqlConn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Choose Image(*.jpg;*.png)|*.jpg;*.png";

            if (opf.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(opf.FileName);
            }

        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            this.Hide();
            frm3.Show();
        }
    }
}
