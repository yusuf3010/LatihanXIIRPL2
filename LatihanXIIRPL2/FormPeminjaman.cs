using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LatihanXIIRPL2
{
    public partial class FormPeminjaman : Form
    {
        string koneksi =
           "server=localhost; " +
           "database=dbperpustakaan " +
           ";uid=root; " +
           "pwd=;";

        public FormPeminjaman()
        {
            InitializeComponent();
        }

        private void Peminjaman_Load(object sender, EventArgs e)
        {
            LoadAnggota();
            LoadBuku();
            LoadPeminjaman();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBoxanggota.SelectedItem == null || comboBoxBuku.SelectedItem == null)
            {
                MessageBox.Show("Pilih ID Anggota dan ID Buku terlebih dahulu!");
                return;
            }

            string anggota = comboBoxanggota.SelectedItem.ToString().Split('-')[0].Trim();
            string buku = comboBoxBuku.SelectedItem.ToString().Split('-')[0].Trim();
            string tglPinjam = dateTimePickerPinjam.Value.ToString("yyyy-MM-dd");
            string tglKembali = dateTimePickerKembali.Value.ToString("yyyy-MM-dd");

            using (MySqlConnection conn = new MySqlConnection(koneksi))
            {
                conn.Open();
                MySqlTransaction trans = conn.BeginTransaction();

                try
                {

                    string insert = @"INSERT INTO peminjaman (id_anggota, id_buku, tanggal_pinjam, tanggal_kembali) 
                                      VALUES (@anggota, @buku, @pinjam, @kembali)";
                    MySqlCommand cmd = new MySqlCommand(insert, conn, trans);
                    cmd.Parameters.AddWithValue("@anggota", anggota);
                    cmd.Parameters.AddWithValue("@buku", buku);
                    cmd.Parameters.AddWithValue("@pinjam", tglPinjam);
                    cmd.Parameters.AddWithValue("@kembali", tglKembali);
                    cmd.ExecuteNonQuery();



                    trans.Commit();
                    MessageBox.Show("Peminjaman berhasil ditambahkan!");

                    LoadBuku();
                    LoadPeminjaman();
                }
                catch (Exception ex)
                {
                    trans.Rollback();
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        void LoadAnggota()
        {
            comboBoxanggota.Items.Clear();
            using (MySqlConnection conn = new MySqlConnection(koneksi))
            {
                conn.Open();
                string query = "SELECT id_anggota, nama FROM anggota";
                MySqlCommand cmd = new MySqlCommand(query, conn);

                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    comboBoxanggota.Items.Add(dr["id_anggota"].ToString() + " - " + dr["nama"].ToString());
                }
            }
        }

        void LoadPeminjaman()
        {
            using (MySqlConnection conn = new MySqlConnection(koneksi))
            {
                conn.Open();
                string query = @"SELECT p.id_peminjaman, a.nama AS Nama_Anggota, b.judul AS Judul_Buku, 
                                 p.tanggal_pinjam, p.tanggal_kembali
                                 FROM peminjaman p
                                 JOIN anggota a ON p.id_anggota = a.id_anggota
                                 JOIN buku b ON p.id_buku = b.id_buku";
                MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        void LoadBuku()
        {
            comboBoxBuku.Items.Clear();
            using (MySqlConnection conn = new MySqlConnection(koneksi))
            {
                conn.Open();
                string query = "SELECT id_buku, judul FROM buku";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    comboBoxBuku.Items.Add(dr["id_buku"].ToString() + " - " + dr["judul"].ToString());
                }
            }
        }

        private void buttonexit_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.ShowDialog();
            this.Hide();
        }

        private void buttondelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Pilih baris yang akan dihapus terlebih dahulu!");
                return;
            }

            MySqlConnection conn = new MySqlConnection(koneksi);
            try
            {
                conn.Open();
                string query = "DELETE FROM peminjaman WHERE id_peminjaman = @id";

                string idToDelete = dataGridView1.SelectedRows[0].Cells["id"].Value.ToString();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", idToDelete);
                cmd.ExecuteNonQuery();

                button1_Click(sender, e);
                LoadPeminjaman();
                MessageBox.Show("Data berhasil dihapus");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menghapus data: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FormPeminjaman_Load(object sender, EventArgs e)
        {
            LoadAnggota();
            LoadBuku();
            LoadPeminjaman();
        }
    }

}