namespace PenjualanMebelApp
{
    public class Transaksi
    {
        public string NamaPembeli { get; set; }
        public string NamaProduk { get; set; }
        public int Jumlah { get; set; }
        public decimal HargaSatuan { get; set; }
        public decimal Total => Jumlah * HargaSatuan;

        public override string ToString()
        {
            return $"{NamaPembeli} membeli {Jumlah} x {NamaProduk} @ Rp {HargaSatuan:N0} = Rp {Total:N0}";
        }
    }
}
