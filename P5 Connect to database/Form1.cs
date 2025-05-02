using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace StudentDesktopApp
{
    public partial class Form1 : Form
    {
        private string connStr = "server=localhost;user=root;password=;database=mebel;port=3306";

        public Form1()
        {
            InitializeComponent();
            this.txtHarga.KeyPress += new KeyPressEventHandler(txtHarga_KeyPress);
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtHarga.Text))
            {
                MessageBox.Show("Harga tidak boleh kosong.");
                return;
            }

            if (!decimal.TryParse(txtHarga.Text, out decimal harga) || harga <= 0)
            {
                MessageBox.Show("Harga harus berupa angka positif.");
                return;
            }
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO barang (kode, nama, harga) VALUES (@kode, @nama, @harga)";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@kode", txtKode.Text);
                    cmd.Parameters.AddWithValue("@nama", txtNama.Text);
                    cmd.Parameters.AddWithValue("@harga", txtHarga.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data berhasil disimpan!");
                    txtKode.Clear();
                    txtNama.Clear();
                    txtHarga.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void btnLihat_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM barang";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void txtHarga_KeyPress(object sender, KeyPressEventArgs e)
{
            // Hanya izinkan angka, backspace, dan titik/koma
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != ',')
            {
                e.Handled = true;
            }

            // Hanya satu titik atau koma yang diizinkan
            TextBox textBox = sender as TextBox;
            if ((e.KeyChar == '.' || e.KeyChar == ',') && (textBox.Text.Contains(".") || textBox.Text.Contains(",")))
            {
                e.Handled = true;
            }
        }
    }
}