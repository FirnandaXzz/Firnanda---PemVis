using MebelpApp.Models;
using MebelpApp.Views;
using System;
using System.Data;
using System.Windows.Forms;

namespace MebelpApp.Controllers
{
    public class TransaksiController
    {
        private TransaksiModel transaksiModel;
        private BarangModel barangModel;
        private FormTransaksiView view;
        private FormUtamaView formUtama;

        public TransaksiController(FormTransaksiView view, FormUtamaView formUtama)
        {
            this.view = view;
            this.formUtama = formUtama;
            transaksiModel = new TransaksiModel();
            barangModel = new BarangModel();

            view.comboBoxBarang.SelectedIndexChanged += ComboBoxBarang_SelectedIndexChanged;
            view.txtJumlah.TextChanged += TxtJumlah_TextChanged;
            view.btnSimpan.Click += BtnSimpan_Click;
            view.btnKembali.Click += BtnKembali_Click;
            view.btnLihatData.Click += BtnLihatData_Click;
            view.btnEdit.Click += BtnEdit_Click;
            view.btnHapus.Click += BtnHapus_Click;

            LoadBarang();
            LoadTransaksi();
        }

        private void LoadBarang()
        {
            DataTable dtBarang = barangModel.GetBarangForComboBox();
            foreach (DataRow row in dtBarang.Rows)
            {
                view.comboBoxBarang.Items.Add($"{row["kode"]} - {row["nama"]}");
            }
        }

        private void LoadTransaksi()
        {
            view.dataGridViewTransaksi.DataSource = transaksiModel.GetAllTransaksi();
        }

        private void ComboBoxBarang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (view.comboBoxBarang.SelectedItem == null) return;

            string kode = view.comboBoxBarang.SelectedItem.ToString().Split(" - ")[0];
            decimal harga = barangModel.GetHargaBarang(kode);
            view.txtHarga.Text = harga.ToString();
            UpdateTotal();
        }

        private void TxtJumlah_TextChanged(object sender, EventArgs e)
        {
            UpdateTotal();
        }

        private void UpdateTotal()
        {
            if (decimal.TryParse(view.txtHarga.Text, out decimal harga) &&
                int.TryParse(view.txtJumlah.Text, out int jumlah))
            {
                decimal total = harga * jumlah;
                view.lblTotal.Text = $"Total: {total:N0}";
            }
            else
            {
                view.lblTotal.Text = "Total: 0";
            }
        }

        private void BtnSimpan_Click(object sender, EventArgs e)
        {
            if (view.comboBoxBarang.SelectedItem == null ||
                !int.TryParse(view.txtJumlah.Text, out int jumlah) ||
                jumlah <= 0)
            {
                MessageBox.Show("Lengkapi data transaksi.");
                return;
            }

            string kode = view.comboBoxBarang.SelectedItem.ToString().Split(" - ")[0];
            string nama = view.comboBoxBarang.SelectedItem.ToString().Split(" - ")[1];
            decimal.TryParse(view.txtHarga.Text, out decimal harga);
            decimal total = harga * jumlah;

            // Cek stok
            int stokTersedia = barangModel.GetStokBarang(kode);
            if (stokTersedia < jumlah)
            {
                MessageBox.Show($"Stok tidak cukup. Stok tersedia: {stokTersedia}");
                return;
            }

            // Simpan transaksi
            if (transaksiModel.AddTransaksi(kode, nama, harga, jumlah, total))
            {
                // Update stok
                if (barangModel.UpdateStokBarang(kode, jumlah))
                {
                    MessageBox.Show("Transaksi berhasil disimpan!");
                    view.txtJumlah.Clear();
                    view.lblTotal.Text = "Total: 0";
                    LoadTransaksi();
                }
                else
                {
                    MessageBox.Show("Gagal memperbarui stok barang.");
                }
            }
            else
            {
                MessageBox.Show("Gagal menyimpan transaksi.");
            }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (view.dataGridViewTransaksi.SelectedRows.Count == 0)
            {
                MessageBox.Show("Pilih data yang ingin diedit.");
                return;
            }

            DataGridViewRow row = view.dataGridViewTransaksi.SelectedRows[0];
            string kode = row.Cells["kode_barang"].Value.ToString();
            string jumlahInput = Microsoft.VisualBasic.Interaction.InputBox("Masukkan jumlah baru:", "Edit Jumlah", row.Cells["jumlah"].Value.ToString());

            if (int.TryParse(jumlahInput, out int jumlahBaru) && jumlahBaru > 0)
            {
                decimal harga = Convert.ToDecimal(row.Cells["harga"].Value);
                decimal totalBaru = harga * jumlahBaru;
                DateTime tanggal = Convert.ToDateTime(row.Cells["tanggal"].Value);

                if (transaksiModel.UpdateTransaksi(kode, tanggal, jumlahBaru, totalBaru))
                {
                    MessageBox.Show("Data berhasil diubah.");
                    LoadTransaksi();
                }
                else
                {
                    MessageBox.Show("Gagal mengedit data.");
                }
            }
            else
            {
                MessageBox.Show("Jumlah tidak valid.");
            }
        }

        private void BtnHapus_Click(object sender, EventArgs e)
        {
            if (view.dataGridViewTransaksi.SelectedRows.Count == 0)
            {
                MessageBox.Show("Pilih data yang ingin dihapus.");
                return;
            }

            DataGridViewRow row = view.dataGridViewTransaksi.SelectedRows[0];
            string kode = row.Cells["kode_barang"].Value.ToString();
            DateTime tanggal = Convert.ToDateTime(row.Cells["tanggal"].Value);

            DialogResult result = MessageBox.Show("Yakin ingin menghapus transaksi ini?", "Konfirmasi", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                if (transaksiModel.DeleteTransaksi(kode, tanggal))
                {
                    MessageBox.Show("Data berhasil dihapus.");
                    LoadTransaksi();
                }
                else
                {
                    MessageBox.Show("Gagal menghapus data.");
                }
            }
        }

        private void BtnKembali_Click(object sender, EventArgs e)
        {
            view.Close();
            formUtama.Show();
        }

        private void BtnLihatData_Click(object sender, EventArgs e)
        {
            LoadTransaksi();
        }
    }
}