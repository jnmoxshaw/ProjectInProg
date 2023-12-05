namespace StudentRegForm
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            comboBox1 = new ComboBox();
            label5 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label6 = new Label();
            comboBox2 = new ComboBox();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            button2 = new Button();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(20, 78);
            textBox1.Margin = new Padding(2, 3, 2, 3);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(235, 30);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(20, 122);
            textBox2.Margin = new Padding(2, 3, 2, 3);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(235, 30);
            textBox2.TabIndex = 3;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(20, 164);
            textBox3.Margin = new Padding(2, 3, 2, 3);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(235, 30);
            textBox3.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            label1.Location = new Point(20, 59);
            label1.Name = "label1";
            label1.Size = new Size(122, 24);
            label1.TabIndex = 6;
            label1.Text = "Last name *";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            label2.Location = new Point(20, 103);
            label2.Name = "label2";
            label2.Size = new Size(124, 24);
            label2.TabIndex = 7;
            label2.Text = "First name *";
            label2.Click += label2_Click_2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            label3.Location = new Point(20, 145);
            label3.Name = "label3";
            label3.Size = new Size(143, 24);
            label3.TabIndex = 8;
            label3.Text = "Middle name *";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            label4.Location = new Point(20, 207);
            label4.Name = "label4";
            label4.Size = new Size(100, 24);
            label4.TabIndex = 9;
            label4.Text = "Gender * ";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Male", "Female", "Prefer not to say" });
            comboBox1.Location = new Point(93, 204);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(162, 31);
            comboBox1.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            label5.Location = new Point(20, 237);
            label5.Name = "label5";
            label5.Size = new Size(142, 24);
            label5.TabIndex = 11;
            label5.Text = "Date of birth *";
            label5.Click += label5_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(20, 259);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 30);
            dateTimePicker1.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            label6.Location = new Point(20, 294);
            label6.Name = "label6";
            label6.Size = new Size(187, 24);
            label6.TabIndex = 13;
            label6.Text = "Program to apply *";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "BS in Information Technology (BSIT)", "BS in Computer Science (BSCS)", "BS in Information Systems (BSIS)", "2-yr. Information Technology (IT)", "2-yr. Associate in Computer Technology (ACT)", "BS in Business Administration (BSBA)", "BS in Accountancy (BSA)", "BS in Accounting Information System (BSAIS)", "BS in Management Accounting (BSMA)", "BS in Retail Technology and Consumer Science (BSRTCS)", "2-yr. Associate in Retail Technology (ART)", "BS in Hospitality Management (BSHM)", "BS in Culinary Management (BSCM)", "3-yr. Hotel and Restaurant Administration (HRA)", "2-yr. Hospitality and Restaurant Services (HRS)", "BS in Tourism Management (BSTM)", "2-yr. Tourism and Events Management (TEM)", "BS in Computer Engineering (BSCpE)", "Bachelor of Multimedia Arts (BMMA)", "BA in Communication (BACOMM)", "Bachelor of Science in Marine Transportation (BSMT)", "Bachelor of Science in Marine Engineering (BSMarE)", "Bachelor of Science in Naval Architecture and Marine Engineering (BSNAME)" });
            comboBox2.Location = new Point(20, 313);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(235, 31);
            comboBox2.TabIndex = 14;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.GradientActiveCaption;
            button1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.HighlightText;
            button1.Location = new Point(345, 313);
            button1.Name = "button1";
            button1.Size = new Size(138, 39);
            button1.TabIndex = 15;
            button1.Text = "Register";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ActiveCaption;
            pictureBox1.Location = new Point(310, 55);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(214, 198);
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.GradientActiveCaption;
            button2.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.HighlightText;
            button2.Location = new Point(373, 259);
            button2.Name = "button2";
            button2.Size = new Size(77, 27);
            button2.TabIndex = 17;
            button2.Text = "Browse";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(12, 22);
            label7.Name = "label7";
            label7.Size = new Size(343, 30);
            label7.TabIndex = 18;
            label7.Text = "Student Registration Form";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(560, 381);
            Controls.Add(label7);
            Controls.Add(button2);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(comboBox2);
            Controls.Add(label6);
            Controls.Add(dateTimePicker1);
            Controls.Add(label5);
            Controls.Add(comboBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(2, 3, 2, 3);
            Name = "Form1";
            Text = "Student Registration";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox comboBox1;
        private Label label5;
        private DateTimePicker dateTimePicker1;
        private Label label6;
        private ComboBox comboBox2;
        private Button button1;
        private PictureBox pictureBox1;
        private Button button2;
        private Label label7;
    }
}
