using System;

class KiralikArac
{
    // Özellikler
    public string Plaka { get; private set; }
    public decimal GunlukUcret { get; private set; }
    public bool MusaitMi { get; private set; }

    // Yapıcı Metot
    public KiralikArac(string plaka, decimal gunlukUcret)
    {
        Plaka = plaka;
        GunlukUcret = gunlukUcret;
        MusaitMi = true; // Varsayılan olarak araç müsait
    }

    // Aracı kiralama metodu
    public void AraciKirala()
    {
        if (MusaitMi)
        {
            MusaitMi = false;
            Console.WriteLine($"{Plaka} plakalı araç kiralandı.");
        }
        else
        {
            Console.WriteLine($"{Plaka} plakalı araç zaten kiralanmış durumda.");
        }
    }

    // Aracı teslim etme metodu
    public void AraciTeslimEt()
    {
        if (!MusaitMi)
        {
            MusaitMi = true;
            Console.WriteLine($"{Plaka} plakalı araç teslim edildi.");
        }
        else
        {
            Console.WriteLine($"{Plaka} plakalı araç zaten müsait.");
        }
    }

    // Aracın durumunu gösteren metot
    public void AracDurumunuGoster()
    {
        string durum = MusaitMi ? "Müsait" : "Kiralanmış";
        Console.WriteLine($"{Plaka} plakalı araç - Durum: {durum}, Günlük Ücret: {GunlukUcret} TL");
    }
}

class Program
{
    static void Main()
    {
        // Yeni bir KiralikArac nesnesi oluşturuyoruz
        KiralikArac arac = new KiralikArac("34ABC123", 300);

        // Aracın durumunu göster
        arac.AracDurumunuGoster();

        // Aracı kirala
        arac.AraciKirala();

        // Aracın durumunu tekrar göster
        arac.AracDurumunuGoster();

        // Aracı teslim et
        arac.AraciTeslimEt();

        // Aracın güncel durumunu tekrar göster
        arac.AracDurumunuGoster();

        // Konsol ekranını açık tutar
        Console.ReadLine();
    }
}
