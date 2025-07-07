using System;
using System.Drawing;
using System.Windows.Forms;

namespace MebelpApp.Views
{
    public class FormUtamaView : Form
    {
        public Button btnInputBarang { get; private set; }
        public Button btnTransaksi { get; private set; }
        public Label lblTitle { get; private set; }

        public FormUtamaView()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.btnInputBarang = new Button();
            this.btnTransaksi = new Button();
            this.lblTitle = new Label();
            this.SuspendLayout();

            // lblTitle
            this.lblTitle.Text = "SEMOYO MEBEL";
            this.lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            this.lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            this.lblTitle.Size = new Size(400, 50);
            this.lblTitle.Location = new Point((800 - 400) / 2, 60);

            // btnInputBarang
            this.btnInputBarang.Name = "btnInputBarang";
            this.btnInputBarang.Size = new Size(200, 50);
            this.btnInputBarang.Location = new Point((800 - 200) / 2, 150);
            this.btnInputBarang.Text = "Input Barang";
            this.btnInputBarang.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            this.btnInputBarang.BackColor = Color.DodgerBlue;
            this.btnInputBarang.ForeColor = Color.White;
            this.btnInputBarang.FlatStyle = FlatStyle.Flat;

            // btnTransaksi
            this.btnTransaksi.Name = "btnTransaksi";
            this.btnTransaksi.Size = new Size(200, 50);
            this.btnTransaksi.Location = new Point((800 - 200) / 2, 220);
            this.btnTransaksi.Text = "Transaksi";
            this.btnTransaksi.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            this.btnTransaksi.BackColor = Color.MediumSeaGreen;
            this.btnTransaksi.ForeColor = Color.White;
            this.btnTransaksi.FlatStyle = FlatStyle.Flat;

            // Form
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.ClientSize = new Size(800, 600);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnInputBarang);
            this.Controls.Add(this.btnTransaksi);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Name = "FormUtamaView";
            this.Text = "MebelpApp - Menu Utama";
            this.ResumeLayout(false);
        }
    }
}