namespace LatihanXIIRPL2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void formBukuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormBuku f = new FormBuku();
            f.ShowDialog();
            this.Close();
        }

        private void formAnggotaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAnggota f = new FormAnggota();
            f.ShowDialog();
            this.Close();
        }

        private void formPeminjamanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPeminjaman f = new FormPeminjaman();
            f.ShowDialog();
            this.Close();
        }
    }
}
