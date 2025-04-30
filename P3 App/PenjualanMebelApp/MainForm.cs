using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PenjualanMebelApp
{
    public class MainForm : Form
    {
        private TextBox txtNamaBarang;
        private NumericUpDown numJumlah;
        private TextBox txtHarga;
        private Button btnTambah;
        private ListBox lstPenjualan;
        private List<MebelItem> daftarPenjualan = new List<MebelItem>();

        public MainForm()
        {
            this.Text = "Form Penjualan Mebel";
            this.Width = 450;
            this.Height = 400;

            Label lblNama = new Label() { Text = "Nama Barang", Top = 20, Left = 20 };
            txtNamaBarang = new TextBox() { Top = 40, Left = 20, Width = 200 };

            Label lblJumlah = new Label() { Text = "Jumlah", Top = 80, Left = 20 };
            numJumlah = new NumericUpDown() { Top = 100, Left = 20, Width = 100, Minimum = 1, Maximum = 1000 };

            Label lblHarga = new Label() { Text = "Harga Satuan", Top = 140, Left = 20 };
            txtHarga = new TextBox() { Top = 160, Left = 20, Width = 200 };

            btnTambah = new Button() { Text = "Tambah Penjualan", Top = 200, Left = 20 };
            btnTambah.Click += BtnTambah_Click;

            lstPenjualan = new ListBox() { Top = 240, Left = 20, Width = 380, Height = 100 };

            this.Controls.Add(lblNama);
            this.Controls.Add(txtNamaBarang);
            this.Controls.Add(lblJumlah);
            this.Controls.Add(numJumlah);
            this.Controls.Add(lblHarga);
            this.Controls.Add(txtHarga);
            this.Controls.Add(btnTambah);
            this.Controls.Add(lstPenjualan);
        }

        private void BtnTambah_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNamaBarang.Text) || string.IsNullOrWhiteSpace(txtHarga.Text))
            {
                MessageBox.Show("Harap isi Nama Barang dan Harga.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txtHarga.Text, out decimal hargaSatuan))
            {
                MessageBox.Show("Harga harus berupa angka desimal yang valid.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MebelItem item = new MebelItem
            {
                NamaBarang = txtNamaBarang.Text,
                Jumlah = (int)numJumlah.Value,
                HargaSatuan = hargaSatuan
            };

            daftarPenjualan.Add(item);
            lstPenjualan.Items.Add(item.ToString());

            txtNamaBarang.Clear();
            txtHarga.Clear();
            numJumlah.Value = 1;
        }

        private void InitializeComponent()
        {
        }
    }
}
