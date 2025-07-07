using MebelpApp.Controllers;
using MebelpApp.Views;
using System;
using System.Windows.Forms;

namespace MebelpApp
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Initialize main form and controllers
            FormUtamaView formUtama = new FormUtamaView();
            
            // Setup event handlers for main form buttons
            formUtama.btnInputBarang.Click += (sender, e) =>
            {
                FormBarangView formBarang = new FormBarangView();
                new BarangController(formBarang, formUtama);
                formBarang.Show();
                formUtama.Hide();
            };

            formUtama.btnTransaksi.Click += (sender, e) =>
            {
                FormTransaksiView formTransaksi = new FormTransaksiView();
                new TransaksiController(formTransaksi, formUtama);
                formTransaksi.Show();
                formUtama.Hide();
            };

            Application.Run(formUtama);
        }
    }
}