using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace LatihanXIIRPL2
{
    public partial class FormBuku : Form
    {
        public FormBuku()
        {
            InitializeComponent();
        }

        private void refreshdata()
        {
            MySqlConnection conn = new MySqlConnection("server=localhost;" +
                "database=dbperpustakaan;uid=root;pwd=;");
            try
            {
                conn.Open();
                string query = "SELECT * FROM buku";
                MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("MySql Eror dengan info :" + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        private void kosongkanform()
        {
            txtISBN.Clear();
            txtJudul.Clear();
            txtPenerbit.Clear();
            txtPengarang.Clear();
        }
        private void tampilData()
        {
            txtISBN.Text = dataGridView1.SelectedCells[1].Value.ToString();
            txtJudul.Text = dataGridView1.SelectedCells[1].Value.ToString();
            txtPenerbit.Text = dataGridView1.SelectedCells[1].Value.ToString();
            txtPengarang.Text = dataGridView1.SelectedCells[1].Value.ToString();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection("server=localhost;" +
                "database=dbperpustakaan;uid=root;pwd=;");

            try
            {
                conn.Open();
                string query = "INSERT INTO buku(isbn, judul, penerbit, pengarang) " +
               "VALUES (@isbn, @judul, @penerbit, @pengarang)";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@isbn", txtISBN.Text);
                cmd.Parameters.AddWithValue("@judul", txtJudul.Text);
                cmd.Parameters.AddWithValue("@penerbit", txtPenerbit.Text);
                cmd.Parameters.AddWithValue("@pengarang", txtPengarang.Text);
                int rows = cmd.ExecuteNonQuery(); // jalankan query
                kosongkanform();
                if (rows > 0)
                {
                    MessageBox.Show("Data berhasil disimpan!");
                }
                else
                {
                    MessageBox.Show("Data gagal disimpan.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MySql Eror dengan info :" + ex.Message);
            }
            finally
            {
                conn.Close();
            }

        }

        private void btnTampil_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection("server=localhost;" +
                "database=dbperpustakaan;uid=root;pwd=;");
            try
            {
                conn.Open();
                string query = "SELECT * FROM buku";
                MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("MySql Eror dengan info :" + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection("server=localhost;database=dbperpustakaan;uid=root;pwd=;");

            try
            {
                conn.Open();

                string query = "DELETE FROM buku WHERE id = @id";
                MySqlCommand cmd = new MySqlCommand(query, conn);

                // pastikan nama kolom sama dengan yang ada di DataGridView
                cmd.Parameters.AddWithValue("@id", dataGridView1.CurrentRow.Cells["id"].Value);

                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    MessageBox.Show("Data berhasil dihapus!");
                    btnTampil_Click(sender, e); // refresh grid
                }
                else
                {
                    MessageBox.Show("Data tidak ditemukan / gagal dihapus.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal hapus: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void FormBuku_Load(object sender, EventArgs e)
        {
            refreshdata();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tampilData();
        }
    }
}

