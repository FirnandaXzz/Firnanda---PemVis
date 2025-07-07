using System;
using System.Drawing;
using System.Windows.Forms;

namespace MebelpApp.Views
{
    public class FormTransaksiView : Form
    {
        public ComboBox comboBoxBarang { get; private set; }
        public TextBox txtHarga { get; private set; }
        public TextBox txtJumlah { get; private set; }
        public Button btnSimpan { get; private set; }
        public Label lblTotal { get; private set; }
        public Button btnKembali { get; private set; }
        public Button btnLihatData { get; private set; }
        public DataGridView dataGridViewTransaksi { get; private set; }
        public Button btnEdit { get; private set; }
        public Button btnHapus { get; private set; }

        public FormTransaksiView()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.Text = "Transaksi Penjualan Mebel";
            this.ClientSize = new Size(800, 600);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.WhiteSmoke;

            comboBoxBarang = new ComboBox()
            {
                Location = new Point(30, 30),
                Size = new Size(300, 23),
                DropDownStyle = ComboBoxStyle.DropDownList
            };

            txtHarga = new TextBox()
            {
                Location = new Point(30, 70),
                Size = new Size(300, 23),
                ReadOnly = true,
                PlaceholderText = "Harga"
            };

            txtJumlah = new TextBox()
            {
                Location = new Point(30, 110),
                Size = new Size(300, 23),
                PlaceholderText = "Jumlah"
            };

            lblTotal = new Label()
            {
                Location = new Point(30, 150),
                Size = new Size(300, 23),
                Text = "Total: 0",
                Font = new Font("Segoe UI", 10, FontStyle.Bold)
            };

            btnSimpan = new Button()
            {
                Location = new Point(30, 190),
                Size = new Size(300, 30),
                Text = "Simpan Transaksi"
            };

            btnKembali = new Button()
            {
                Location = new Point(30, 230),
                Size = new Size(140, 30),
                Text = "Kembali ke Utama"
            };

            btnLihatData = new Button()
            {
                Location = new Point(190, 230),
                Size = new Size(140, 30),
                Text = "Lihat Data"
            };

            dataGridViewTransaksi = new DataGridView()
            {
                Location = new Point(360, 30),
                Size = new Size(400, 400),
                ReadOnly = true,
                AllowUserToAddRows = false,
                SelectionMode = DataGridViewSelectionMode.FullRowSelect
            };

            btnEdit = new Button()
            {
                Location = new Point(360, 450),
                Size = new Size(130, 30),
                Text = "Edit"
            };

            btnHapus = new Button()
            {
                Location = new Point(500, 450),
                Size = new Size(130, 30),
                Text = "Hapus"
            };

            this.Controls.AddRange(new Control[]
            {
                comboBoxBarang, txtHarga, txtJumlah, lblTotal,
                btnSimpan, btnKembali, btnLihatData,
                dataGridViewTransaksi, btnEdit, btnHapus
            });
        }
    }
}