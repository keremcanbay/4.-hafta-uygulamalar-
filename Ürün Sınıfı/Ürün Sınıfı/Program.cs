using System;

class Urun
{
    // Özellikler
    public string Ad { get; private set; }
    public decimal Fiyat { get; private set; }
    private decimal _indirim;

    // İndirim özelliği 0 ile 50 arasında sınırlandırılmıştır
    public decimal Indirim
    {
        get { return _indirim; }
        set
        {
            if (value >= 0 && value <= 50)
                _indirim = value;
            else
                Console.WriteLine("İndirim oranı 0 ile 50 arasında olmalıdır.");
        }
    }

    // Yapıcı Metot
    public Urun(string ad, decimal fiyat)
    {
        Ad = ad;
        Fiyat = fiyat;
        _indirim = 0; // Başlangıç indirimi varsayılan olarak 0
    }

    // İndirimli fiyatı hesaplayan metot
    public decimal IndirimliFiyat()
    {
        decimal indirimliFiyat = Fiyat - (Fiyat * _indirim / 100);
        return indirimliFiyat;
    }
}

class Program
{
    static void Main()
    {
        // Yeni bir Ürün nesnesi oluşturuyoruz
        Urun urun = new Urun("Laptop", 5000);

        // Ürünün indirim oranını belirliyoruz
        urun.Indirim = 10; // %10 indirim

        // Ürünün indirimli fiyatını hesaplıyoruz
        Console.WriteLine($"Ürün Adı: {urun.Ad}");
        Console.WriteLine($"Ürünün Orijinal Fiyatı: {urun.Fiyat} TL");
        Console.WriteLine($"İndirim Oranı: %{urun.Indirim}");
        Console.WriteLine($"İndirimli Fiyat: {urun.IndirimliFiyat()} TL");

        // Konsol ekranını açık tutar
        Console.ReadLine();
    }
}
