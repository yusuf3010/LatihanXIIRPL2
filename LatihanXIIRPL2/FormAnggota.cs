using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace LatihanXIIRPL2
{
    public partial class FormAnggota : Form
    {
        // Koneksi string global
        private string koneksiString = "Server=localhost;Database=dbperpustakaan;Uid=root;Pwd=;";

        public FormAnggota()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection koneksi = null;

            try
            {
                string jk = rbLaki.Checked ? "Laki-laki" : "Perempuan";

                koneksi = new MySqlConnection(koneksiString);
                koneksi.Open();

                string query = @"INSERT INTO anggota 
                     (id_anggota, nama, alamat, jenis_kelamin, tanggal_lahir, telepon, jurusan) 
                     VALUES (@id, @nama, @alamat, @jk, @tgl, @telepon, @jurusan)";

                MySqlCommand cmd = new MySqlCommand(query, koneksi);
                cmd.Parameters.AddWithValue("@id", textBox1.Text);
                cmd.Parameters.AddWithValue("@nama", textBox2.Text);
                cmd.Parameters.AddWithValue("@alamat", textBox3.Text);
                cmd.Parameters.AddWithValue("@jk", jk);
                cmd.Parameters.AddWithValue("@tgl", dateTimePicker1.Value.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@telepon", textBox4.Text);
                cmd.Parameters.AddWithValue("@jurusan", comboBox1.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Data berhasil disimpan!", "Informasi");
                TampilData(); // refresh DataGridView 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                if (koneksi != null)
                    koneksi.Close();
            }
        }

        private void TampilData()
        {
            MySqlConnection koneksi = null;

            try
            {
                koneksi = new MySqlConnection(koneksiString);
                koneksi.Open();

                string query = "SELECT * FROM anggota";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, koneksi);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                if (koneksi != null)
                    koneksi.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string id = dataGridView1.SelectedRows[0].Cells["id_anggota"].Value.ToString();
                MySqlConnection koneksi = null;

                try
                {
                    koneksi = new MySqlConnection(koneksiString);
                    koneksi.Open();
                    string query = "DELETE FROM anggota WHERE id_anggota=@id";
                    MySqlCommand cmd = new MySqlCommand(query, koneksi);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data berhasil dihapus!", "Informasi");
                    TampilData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    if (koneksi != null)
                        koneksi.Close();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormAnggota_Load(object sender, EventArgs e)
        {
            TampilData();  
        }
    }
}
