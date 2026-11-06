
class Agen
{
    public string idAgen;
    public string namaAgen;
    public int stokAgen;

    public void TampilInfo()
    {
        Console.WriteLine("Informasi Agen");
    }

    public void TampilInfo(string Idagen, string Namaagen, int Stokagen)
    {
        this.idAgen = Idagen;
        this.namaAgen = Namaagen;
        this.stokAgen = Stokagen;
    }
}

class ProdukGalon
{
    public string idProduk;
    public string namaProduk;
    public int stokGudang;

    public virtual void HitungBiaya(int Jumlah)
    {
        Console.WriteLine($"Harga Produk {namaProduk} seharga Rp.{Jumlah}");
    }

    public void KurangiStok(int jumlah)
    {
        Console.WriteLine($"Sisa Stock {stokGudang}");
    }
}

class GalonAkua : ProdukGalon
{
    public int harga;
}

class GalonBerkeran : ProdukGalon
{
    public int harga;
}


class IDapatDidistribusikan
{
    public void KirimPaket();
}

class DistribusiGalon
{
    public int jumlah; { get; set; }


    //set{
    //    if (jumlah > 0)
    //    {
    //      Console.WriteLine("")
    //    }
    //    else (jumlah < 0)
    //    {
    //      Console.WriteLine("")
    //    }



}
class program
{
    static void Main()
    {
        Agen agen1 = new agen1("1", "Alex", 50);
        Agen agen2 = new agen2("2", "Alex", 50);
        GalonAkua produk1 = new GalonAkua("1", "GalonAkua", 50, 20000);
        GalonBerkeran produk2 = new GalonBerkeran("2", "GalonBerkeran", 40, 12000);
    }
}