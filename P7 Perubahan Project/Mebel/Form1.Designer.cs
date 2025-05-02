namespace MebelpApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.TextBox txtKode;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.TextBox txtHarga;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Button btnLihat;
        private System.Windows.Forms.DataGridView dataGridView1;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtKode = new System.Windows.Forms.TextBox();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.txtHarga = new System.Windows.Forms.TextBox();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.btnLihat = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();

            // txtKode
            this.txtKode.Location = new System.Drawing.Point(30, 30);
            this.txtKode.Name = "txtKode";
            this.txtKode.PlaceholderText = "Kode";
            this.txtKode.Size = new System.Drawing.Size(200, 23);

            // txtNama
            this.txtNama.Location = new System.Drawing.Point(30, 60);
            this.txtNama.Name = "txtNama";
            this.txtNama.PlaceholderText = "Nama";
            this.txtNama.Size = new System.Drawing.Size(200, 23);

            // txtHarga
            this.txtHarga.Location = new System.Drawing.Point(30, 90);
            this.txtHarga.Name = "txtHarga";
            this.txtHarga.PlaceholderText = "Harga";
            this.txtHarga.Size = new System.Drawing.Size(200, 23);

            // btnSimpan
            this.btnSimpan.Location = new System.Drawing.Point(250, 30);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(100, 30);
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = true;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);

            // btnLihat
            this.btnLihat.Location = new System.Drawing.Point(250, 70);
            this.btnLihat.Name = "btnLihat";
            this.btnLihat.Size = new System.Drawing.Size(100, 30);
            this.btnLihat.Text = "Lihat Data";
            this.btnLihat.UseVisualStyleBackColor = true;
            this.btnLihat.Click += new System.EventHandler(this.btnLihat_Click);

            // dataGridView1
            this.dataGridView1.Location = new System.Drawing.Point(30, 130);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(450, 200);
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

            // Form1
            this.ClientSize = new System.Drawing.Size(520, 360);
            this.Controls.Add(this.txtKode);
            this.Controls.Add(this.txtNama);
            this.Controls.Add(this.txtHarga);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.btnLihat);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Data Penjualan";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}