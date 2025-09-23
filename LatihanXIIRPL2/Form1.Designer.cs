namespace LatihanXIIRPL2
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
            menuStrip1 = new MenuStrip();
            menuToolStripMenuItem = new ToolStripMenuItem();
            formBukuToolStripMenuItem = new ToolStripMenuItem();
            formAnggotaToolStripMenuItem = new ToolStripMenuItem();
            formPeminjamanToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 33);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            menuToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { formBukuToolStripMenuItem, formAnggotaToolStripMenuItem, formPeminjamanToolStripMenuItem });
            menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            menuToolStripMenuItem.Size = new Size(73, 29);
            menuToolStripMenuItem.Text = "Menu";
            // 
            // formBukuToolStripMenuItem
            // 
            formBukuToolStripMenuItem.Name = "formBukuToolStripMenuItem";
            formBukuToolStripMenuItem.Size = new Size(270, 34);
            formBukuToolStripMenuItem.Text = "FormBuku";
            formBukuToolStripMenuItem.Click += formBukuToolStripMenuItem_Click;
            // 
            // formAnggotaToolStripMenuItem
            // 
            formAnggotaToolStripMenuItem.Name = "formAnggotaToolStripMenuItem";
            formAnggotaToolStripMenuItem.Size = new Size(270, 34);
            formAnggotaToolStripMenuItem.Text = "FormAnggota";
            formAnggotaToolStripMenuItem.Click += formAnggotaToolStripMenuItem_Click;
            // 
            // formPeminjamanToolStripMenuItem
            // 
            formPeminjamanToolStripMenuItem.Name = "formPeminjamanToolStripMenuItem";
            formPeminjamanToolStripMenuItem.Size = new Size(270, 34);
            formPeminjamanToolStripMenuItem.Text = "FormPeminjaman";
            formPeminjamanToolStripMenuItem.Click += formPeminjamanToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "  MenuUtama";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuToolStripMenuItem;
        private ToolStripMenuItem formBukuToolStripMenuItem;
        private ToolStripMenuItem formAnggotaToolStripMenuItem;
        private ToolStripMenuItem formPeminjamanToolStripMenuItem;
    }
}
