namespace LatihanXIIRPL2
{
    partial class FormPeminjaman
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            button1 = new Button();
            buttondelete = new Button();
            buttonexit = new Button();
            mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            comboBoxanggota = new ComboBox();
            comboBoxBuku = new ComboBox();
            dateTimePickerPinjam = new DateTimePicker();
            dateTimePickerKembali = new DateTimePicker();
            mySqlCommand2 = new MySql.Data.MySqlClient.MySqlCommand();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(343, 28);
            label1.Name = "label1";
            label1.Size = new Size(108, 25);
            label1.TabIndex = 0;
            label1.Text = "Peminjaman";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(104, 81);
            label2.Name = "label2";
            label2.Size = new Size(102, 25);
            label2.TabIndex = 1;
            label2.Text = "ID anggota";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(104, 126);
            label3.Name = "label3";
            label3.Size = new Size(75, 25);
            label3.TabIndex = 2;
            label3.Text = "ID buku";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(104, 165);
            label4.Name = "label4";
            label4.Size = new Size(132, 25);
            label4.TabIndex = 3;
            label4.Text = "Tanggal pinjam";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(104, 210);
            label5.Name = "label5";
            label5.Size = new Size(140, 25);
            label5.TabIndex = 4;
            label5.Text = "Tanggal kembali";
            // 
            // button1
            // 
            button1.Location = new Point(104, 253);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 5;
            button1.Text = "Simpan";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // buttondelete
            // 
            buttondelete.Location = new Point(278, 253);
            buttondelete.Name = "buttondelete";
            buttondelete.Size = new Size(112, 34);
            buttondelete.TabIndex = 6;
            buttondelete.Text = "Hapus";
            buttondelete.UseVisualStyleBackColor = true;
            // 
            // buttonexit
            // 
            buttonexit.Location = new Point(435, 253);
            buttonexit.Name = "buttonexit";
            buttonexit.Size = new Size(112, 34);
            buttonexit.TabIndex = 7;
            buttonexit.Text = "Keluar";
            buttonexit.UseVisualStyleBackColor = true;
            // 
            // mySqlCommand1
            // 
            mySqlCommand1.CacheAge = 0;
            mySqlCommand1.Connection = null;
            mySqlCommand1.EnableCaching = false;
            mySqlCommand1.Transaction = null;
            // 
            // comboBoxanggota
            // 
            comboBoxanggota.FormattingEnabled = true;
            comboBoxanggota.Location = new Point(269, 80);
            comboBoxanggota.Name = "comboBoxanggota";
            comboBoxanggota.Size = new Size(182, 33);
            comboBoxanggota.TabIndex = 8;
            // 
            // comboBoxBuku
            // 
            comboBoxBuku.FormattingEnabled = true;
            comboBoxBuku.Location = new Point(269, 122);
            comboBoxBuku.Name = "comboBoxBuku";
            comboBoxBuku.Size = new Size(182, 33);
            comboBoxBuku.TabIndex = 9;
            // 
            // dateTimePickerPinjam
            // 
            dateTimePickerPinjam.Location = new Point(269, 165);
            dateTimePickerPinjam.Name = "dateTimePickerPinjam";
            dateTimePickerPinjam.Size = new Size(300, 31);
            dateTimePickerPinjam.TabIndex = 10;
            // 
            // dateTimePickerKembali
            // 
            dateTimePickerKembali.Location = new Point(269, 204);
            dateTimePickerKembali.Name = "dateTimePickerKembali";
            dateTimePickerKembali.Size = new Size(300, 31);
            dateTimePickerKembali.TabIndex = 11;
            // 
            // mySqlCommand2
            // 
            mySqlCommand2.CacheAge = 0;
            mySqlCommand2.Connection = null;
            mySqlCommand2.EnableCaching = false;
            mySqlCommand2.Transaction = null;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(104, 306);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(477, 132);
            dataGridView1.TabIndex = 12;
            // 
            // FormPeminjaman
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(dateTimePickerKembali);
            Controls.Add(dateTimePickerPinjam);
            Controls.Add(comboBoxBuku);
            Controls.Add(comboBoxanggota);
            Controls.Add(buttonexit);
            Controls.Add(buttondelete);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormPeminjaman";
            Text = "FormPeminjaman";
            Load += FormPeminjaman_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button button1;
        private Button buttondelete;
        private Button buttonexit;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private ComboBox comboBoxanggota;
        private ComboBox comboBoxBuku;
        private DateTimePicker dateTimePickerPinjam;
        private DateTimePicker dateTimePickerKembali;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand2;
        private DataGridView dataGridView1;
    }
}