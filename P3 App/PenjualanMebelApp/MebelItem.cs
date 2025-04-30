namespace PenjualanMebelApp
{
    public class MebelItem
    {
        public string NamaBarang { get; set; }
        public int Jumlah { get; set; }
        public decimal HargaSatuan { get; set; }

        public decimal TotalHarga => Jumlah * HargaSatuan;

        public override string ToString()
        {
            return $"{NamaBarang} - {Jumlah} unit - Rp{HargaSatuan:N0}/unit - Total: Rp{TotalHarga:N0}";
        }
    }
}
