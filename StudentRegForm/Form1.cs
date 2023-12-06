namespace StudentRegForm
{
    public partial class Form1 : Form
    {
        public static string lastName = "";
        public static string firstName = "";
        public static string middleName = "";
        public static string gender = "";
        public static string program = "";
        public static string date = "";

        Form2 frm2 = new Form2();
        public Form1()
        {
            InitializeComponent();

            Form2.dt.Columns.Add("Last Name", typeof(string));
            Form2.dt.Columns.Add("First Name", typeof(string));
            Form2.dt.Columns.Add("Middle Name", typeof(string));
            Form2.dt.Columns.Add("Gender", typeof(string));
            Form2.dt.Columns.Add("Date", typeof(string));
            Form2.dt.Columns.Add("Program", typeof(string));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            firstName = textBox1.Text;
            middleName = textBox2.Text;
            lastName = textBox3.Text;
            Object selectedItem = comboBox1.SelectedItem;
            Object selectedItem2 = comboBox2.SelectedItem;

            gender = selectedItem.ToString();
            program = selectedItem2.ToString();
            date = dateTimePicker1.Value.ToString("yyyy-MM--dd");

            // Debugging Only!
            System.Diagnostics.Debug.WriteLine("First Name: " + firstName);
            System.Diagnostics.Debug.WriteLine("Last Name: " + lastName);
            System.Diagnostics.Debug.WriteLine("Middle Name: " + middleName);
            System.Diagnostics.Debug.WriteLine("Gender: " + gender);
            System.Diagnostics.Debug.WriteLine("Program: " + program);
            System.Diagnostics.Debug.WriteLine("Date: " + date);
            // ----

            
            
            frm2.ShowDialog();
            Form2.dt.Rows.Add(firstName, lastName, middleName, gender, date, program);

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
            frm3.ShowDialog();
        }
    }
}
