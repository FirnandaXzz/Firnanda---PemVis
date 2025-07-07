using MebelpApp.Models;
using MebelpApp.Views;
using System;
using System.Data;
using System.Windows.Forms;

namespace MebelpApp.Controllers
{
    public class BarangController
    {
        private BarangModel model;
        private FormBarangView view;
        private FormUtamaView formUtama;

        public BarangController(FormBarangView view, FormUtamaView formUtama)
        {
            this.view = view;
            this.formUtama = formUtama;
            model = new BarangModel();

            view.btnSimpan.Click += BtnSimpan_Click;
            view.btnEdit.Click += BtnEdit_Click;
            view.btnHapus.Click += BtnHapus_Click;
            view.btnLihat.Click += BtnLihat_Click;
            view.btnKembali.Click += BtnKembali_Click;
            view.dataGridView1.CellClick += DataGridView1_CellClick;
            view.txtHarga.KeyPress += TxtHarga_KeyPress;
            view.txtStok.KeyPress += TxtHarga_KeyPress;

            LoadData();
        }

        private void BtnSimpan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(view.txtKode.Text) || 
                string.IsNullOrWhiteSpace(view.txtNama.Text) || 
                string.IsNullOrWhiteSpace(view.txtHarga.Text) || 
                string.IsNullOrWhiteSpace(view.txtStok.Text))
            {
                MessageBox.Show("Semua field harus diisi.");
                return;
            }

            if (!decimal.TryParse(view.txtHarga.Text, out decimal harga) || harga <= 0)
            {
                MessageBox.Show("Harga harus berupa angka positif.");
                return;
            }

            if (!int.TryParse(view.txtStok.Text, out int stok) || stok < 0)
            {
                MessageBox.Show("Stok harus berupa angka bulat positif.");
                return;
            }

            if (model.AddBarang(view.txtKode.Text, view.txtNama.Text, harga, stok))
            {
                MessageBox.Show("Data berhasil disimpan!");
                ClearFields();
                LoadData();
            }
            else
            {
                MessageBox.Show("Gagal menyimpan data.");
            }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(view.txtHarga.Text, out decimal harga) || 
                !int.TryParse(view.txtStok.Text, out int stok))
            {
                MessageBox.Show("Pastikan harga dan stok valid.");
                return;
            }

            if (model.UpdateBarang(view.txtKode.Text, view.txtNama.Text, harga, stok))
            {
                MessageBox.Show("Data berhasil diubah!");
                ClearFields();
                LoadData();
            }
            else
            {
                MessageBox.Show("Gagal mengubah data.");
            }
        }

        private void BtnHapus_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(view.txtKode.Text))
            {
                MessageBox.Show("Pilih data yang ingin dihapus dari tabel.");
                return;
            }

            if (model.DeleteBarang(view.txtKode.Text))
            {
                MessageBox.Show("Data berhasil dihapus!");
                ClearFields();
                LoadData();
            }
            else
            {
                MessageBox.Show("Gagal menghapus data.");
            }
        }

        private void BtnLihat_Click(object sender, EventArgs e) => LoadData();

        private void BtnKembali_Click(object sender, EventArgs e)
        {
            view.Hide();
            formUtama.Show();
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = view.dataGridView1.Rows[e.RowIndex];
                view.txtKode.Text = row.Cells["kode"].Value.ToString();
                view.txtNama.Text = row.Cells["nama"].Value.ToString();
                view.txtHarga.Text = row.Cells["harga"].Value.ToString();
                view.txtStok.Text = row.Cells["stok"].Value.ToString();
            }
        }

        private void TxtHarga_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != ',')
            {
                e.Handled = true;
            }

            TextBox textBox = sender as TextBox;
            if ((e.KeyChar == '.' || e.KeyChar == ',') && (textBox.Text.Contains(".") || textBox.Text.Contains(",")))
            {
                e.Handled = true;
            }
        }

        private void LoadData()
        {
            view.dataGridView1.DataSource = model.GetAllBarang();
        }

        private void ClearFields()
        {
            view.txtKode.Clear();
            view.txtNama.Clear();
            view.txtHarga.Clear();
            view.txtStok.Clear();
        }
    }
}