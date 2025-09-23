namespace LatihanXIIRPL2
{
    partial class FormAnggota
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            rbLaki = new RadioButton();
            radioButton2 = new RadioButton();
            label6 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label7 = new Label();
            comboBox1 = new ComboBox();
            label8 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(205, 54);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 31);
            textBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(80, 60);
            label1.Name = "label1";
            label1.Size = new Size(105, 25);
            label1.TabIndex = 1;
            label1.Text = "ID Anggota";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(126, 99);
            label2.Name = "label2";
            label2.Size = new Size(59, 25);
            label2.TabIndex = 2;
            label2.Text = "Nama";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(117, 138);
            label3.Name = "label3";
            label3.Size = new Size(68, 25);
            label3.TabIndex = 3;
            label3.Text = "Alamat";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(112, 175);
            label4.Name = "label4";
            label4.Size = new Size(73, 25);
            label4.TabIndex = 4;
            label4.Text = "Telepon";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(69, 215);
            label5.Name = "label5";
            label5.Size = new Size(116, 25);
            label5.TabIndex = 5;
            label5.Text = "Jenis Kelamin";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(205, 96);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(150, 31);
            textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(205, 135);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(150, 31);
            textBox3.TabIndex = 7;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(205, 175);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(150, 31);
            textBox4.TabIndex = 8;
            // 
            // rbLaki
            // 
            rbLaki.AutoSize = true;
            rbLaki.Location = new Point(205, 215);
            rbLaki.Name = "rbLaki";
            rbLaki.Size = new Size(100, 29);
            rbLaki.TabIndex = 9;
            rbLaki.TabStop = true;
            rbLaki.Text = "Laki-laki";
            rbLaki.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(352, 215);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(126, 29);
            radioButton2.TabIndex = 10;
            radioButton2.TabStop = true;
            radioButton2.Text = "Perempuan";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(69, 254);
            label6.Name = "label6";
            label6.Size = new Size(111, 25);
            label6.TabIndex = 11;
            label6.Text = "Tanggal lahir";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(205, 254);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(300, 31);
            dateTimePicker1.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(109, 298);
            label7.Name = "label7";
            label7.Size = new Size(71, 25);
            label7.TabIndex = 13;
            label7.Text = "Jurusan";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "RPL", "TKJ", "MM", "DKV", "OTKP" });
            comboBox1.Location = new Point(205, 298);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(182, 33);
            comboBox1.TabIndex = 14;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(109, 343);
            label8.Name = "label8";
            label8.Size = new Size(0, 25);
            label8.TabIndex = 15;
            // 
            // button1
            // 
            button1.Location = new Point(80, 357);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 16;
            button1.Text = "Simpan";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(222, 357);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 17;
            button2.Text = "Hapus";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(365, 357);
            button3.Name = "button3";
            button3.Size = new Size(112, 34);
            button3.TabIndex = 18;
            button3.Text = "Keluar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(80, 409);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(635, 181);
            dataGridView1.TabIndex = 19;
            // 
            // FormAnggota
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(863, 624);
            Controls.Add(dataGridView1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label8);
            Controls.Add(comboBox1);
            Controls.Add(label7);
            Controls.Add(dateTimePicker1);
            Controls.Add(label6);
            Controls.Add(radioButton2);
            Controls.Add(rbLaki);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Name = "FormAnggota";
            Text = "FormAnggota";
            Load += FormAnggota_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private RadioButton rbLaki;
        private RadioButton radioButton2;
        private Label label6;
        private DateTimePicker dateTimePicker1;
        private Label label7;
        private ComboBox comboBox1;
        private Label label8;
        private Button button1;
        private Button button2;
        private Button button3;
        private DataGridView dataGridView1;
    }
}