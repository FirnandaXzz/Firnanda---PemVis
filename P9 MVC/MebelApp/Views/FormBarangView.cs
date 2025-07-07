using System;
using System.Drawing;
using System.Windows.Forms;

namespace MebelpApp.Views
{
    public class FormBarangView : Form
    {
        public TextBox txtKode { get; private set; }
        public TextBox txtNama { get; private set; }
        public TextBox txtHarga { get; private set; }
        public TextBox txtStok { get; private set; }
        public Button btnSimpan { get; private set; }
        public Button btnEdit { get; private set; }
        public Button btnHapus { get; private set; }
        public Button btnLihat { get; private set; }
        public Button btnKembali { get; private set; }
        public DataGridView dataGridView1 { get; private set; }

        public FormBarangView()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.txtKode = new TextBox();
            this.txtNama = new TextBox();
            this.txtHarga = new TextBox();
            this.txtStok = new TextBox();
            this.btnSimpan = new Button();
            this.btnEdit = new Button();
            this.btnHapus = new Button();
            this.btnLihat = new Button();
            this.btnKembali = new Button();
            this.dataGridView1 = new DataGridView();

            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();

            //Layout constants
            int inputLeft = 30;
            int inputTop = 30;
            int inputWidth = 250;
            int inputHeight = 23;
            int inputSpacing = 35;

            int buttonLeft = inputLeft + inputWidth + 20;
            int buttonTop = inputTop;
            int buttonWidth = 100;
            int buttonHeight = 30;
            int buttonSpacing = 35;

            //TextBoxes
            this.txtKode.Location = new Point(inputLeft, inputTop);
            this.txtKode.Name = "txtKode";
            this.txtKode.PlaceholderText = "Kode Barang";
            this.txtKode.Size = new Size(inputWidth, inputHeight);

            this.txtNama.Location = new Point(inputLeft, inputTop + inputSpacing);
            this.txtNama.Name = "txtNama";
            this.txtNama.PlaceholderText = "Nama Barang";
            this.txtNama.Size = new Size(inputWidth, inputHeight);

            this.txtHarga.Location = new Point(inputLeft, inputTop + 2 * inputSpacing);
            this.txtHarga.Name = "txtHarga";
            this.txtHarga.PlaceholderText = "Harga";
            this.txtHarga.Size = new Size(inputWidth, inputHeight);

            this.txtStok = new TextBox
            {
                Name = "txtStok",
                PlaceholderText = "Stok",
                Location = new Point(inputLeft, inputTop + 3 * inputSpacing),
                Size = new Size(inputWidth, inputHeight)
            };

            //Buttons
            this.btnSimpan.Location = new Point(buttonLeft, buttonTop);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new Size(buttonWidth, buttonHeight);
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = true;

            this.btnEdit.Location = new Point(buttonLeft, buttonTop + buttonSpacing);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new Size(buttonWidth, buttonHeight);
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;

            this.btnHapus.Location = new Point(buttonLeft, buttonTop + 2 * buttonSpacing);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new Size(buttonWidth, buttonHeight);
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseVisualStyleBackColor = true;

            this.btnLihat.Location = new Point(buttonLeft, buttonTop + 3 * buttonSpacing);
            this.btnLihat.Name = "btnLihat";
            this.btnLihat.Size = new Size(buttonWidth, buttonHeight);
            this.btnLihat.Text = "Lihat Data";
            this.btnLihat.UseVisualStyleBackColor = true;

            this.btnKembali.Location = new Point(buttonLeft, buttonTop + 4 * buttonSpacing);
            this.btnKembali.Name = "btnKembali";
            this.btnKembali.Size = new Size(buttonWidth, buttonHeight);
            this.btnKembali.Text = "Kembali";
            this.btnKembali.UseVisualStyleBackColor = true;

            //DataGridView
            this.dataGridView1.Location = new Point(inputLeft, buttonTop + 5 * buttonSpacing + 20);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new Size(740, 300);
            this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.MultiSelect = false;

            //Form
            this.ClientSize = new Size(800, 550);
            this.Controls.Add(this.txtKode);
            this.Controls.Add(this.txtNama);
            this.Controls.Add(this.txtHarga);
            this.Controls.Add(this.txtStok);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.btnLihat);
            this.Controls.Add(this.btnKembali);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormBarangView";
            this.Text = "Manajemen Barang - MebelpApp";

            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}