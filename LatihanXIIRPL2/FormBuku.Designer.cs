namespace LatihanXIIRPL2
{
    partial class FormBuku
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
            txtISBN = new TextBox();
            txtJudul = new TextBox();
            txtPengarang = new TextBox();
            txtPenerbit = new TextBox();
            btnSimpan = new Button();
            btnTutup = new Button();
            btnHapus = new Button();
            dataGridView1 = new DataGridView();
            btnTampil = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(117, 34);
            label1.Name = "label1";
            label1.Size = new Size(50, 25);
            label1.TabIndex = 0;
            label1.Text = "ISBN";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(117, 81);
            label2.Name = "label2";
            label2.Size = new Size(53, 25);
            label2.TabIndex = 1;
            label2.Text = "Judul";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(117, 123);
            label3.Name = "label3";
            label3.Size = new Size(96, 25);
            label3.TabIndex = 2;
            label3.Text = "Pengarang";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(117, 169);
            label4.Name = "label4";
            label4.Size = new Size(76, 25);
            label4.TabIndex = 3;
            label4.Text = "Penerbit";
            label4.Click += label4_Click;
            // 
            // txtISBN
            // 
            txtISBN.Location = new Point(246, 34);
            txtISBN.Name = "txtISBN";
            txtISBN.Size = new Size(260, 31);
            txtISBN.TabIndex = 4;
            // 
            // txtJudul
            // 
            txtJudul.Location = new Point(246, 81);
            txtJudul.Name = "txtJudul";
            txtJudul.Size = new Size(260, 31);
            txtJudul.TabIndex = 5;
            // 
            // txtPengarang
            // 
            txtPengarang.Location = new Point(246, 123);
            txtPengarang.Name = "txtPengarang";
            txtPengarang.Size = new Size(260, 31);
            txtPengarang.TabIndex = 6;
            // 
            // txtPenerbit
            // 
            txtPenerbit.Location = new Point(246, 166);
            txtPenerbit.Name = "txtPenerbit";
            txtPenerbit.Size = new Size(260, 31);
            txtPenerbit.TabIndex = 7;
            // 
            // btnSimpan
            // 
            btnSimpan.Location = new Point(50, 215);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(112, 34);
            btnSimpan.TabIndex = 8;
            btnSimpan.Text = "Simpan";
            btnSimpan.UseVisualStyleBackColor = true;
            btnSimpan.Click += btnSimpan_Click;
            // 
            // btnTutup
            // 
            btnTutup.Location = new Point(187, 215);
            btnTutup.Name = "btnTutup";
            btnTutup.Size = new Size(112, 34);
            btnTutup.TabIndex = 9;
            btnTutup.Text = "Tutup";
            btnTutup.UseVisualStyleBackColor = true;
            btnTutup.Click += button2_Click;
            // 
            // btnHapus
            // 
            btnHapus.Location = new Point(323, 215);
            btnHapus.Name = "btnHapus";
            btnHapus.Size = new Size(112, 34);
            btnHapus.TabIndex = 10;
            btnHapus.Text = "Hapus";
            btnHapus.UseVisualStyleBackColor = true;
            btnHapus.Click += btnHapus_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(44, 272);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(526, 187);
            dataGridView1.TabIndex = 11;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btnTampil
            // 
            btnTampil.Location = new Point(458, 215);
            btnTampil.Name = "btnTampil";
            btnTampil.Size = new Size(112, 34);
            btnTampil.TabIndex = 12;
            btnTampil.Text = "Tampilkan";
            btnTampil.UseVisualStyleBackColor = true;
            btnTampil.Click += btnTampil_Click;
            // 
            // FormBuku
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(888, 514);
            Controls.Add(btnTampil);
            Controls.Add(dataGridView1);
            Controls.Add(btnHapus);
            Controls.Add(btnTutup);
            Controls.Add(btnSimpan);
            Controls.Add(txtPenerbit);
            Controls.Add(txtPengarang);
            Controls.Add(txtJudul);
            Controls.Add(txtISBN);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormBuku";
            Text = "FormBuku";
            Load += FormBuku_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtISBN;
        private TextBox txtJudul;
        private TextBox txtPengarang;
        private TextBox txtPenerbit;
        private Button btnSimpan;
        private Button btnTutup;
        private Button btnHapus;
        private DataGridView dataGridView1;
        private Button btnTampil;
    }
}