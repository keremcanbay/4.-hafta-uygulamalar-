using System;

class BankaHesabi
{
    // Özellikler
    public string HesapNumarasi { get; private set; }
    private decimal Bakiye { get; set; }

    // Yapıcı Metot
    public BankaHesabi(string hesapNumarasi, decimal ilkBakiye)
    {
        HesapNumarasi = hesapNumarasi;
        Bakiye = ilkBakiye;
    }

    // Para Yatırma Metodu
    public void ParaYatir(decimal miktar)
    {
        if (miktar > 0)
        {
            Bakiye += miktar;
            Console.WriteLine($"{miktar} TL başarıyla yatırıldı. Güncel bakiye: {Bakiye} TL");
        }
        else
        {
            Console.WriteLine("Lütfen geçerli bir miktar girin.");
        }
    }

    // Para Çekme Metodu
    public void ParaCek(decimal miktar)
    {
        if (miktar > 0 && miktar <= Bakiye)
        {
            Bakiye -= miktar;
            Console.WriteLine($"{miktar} TL başarıyla çekildi. Güncel bakiye: {Bakiye} TL");
        }
        else if (miktar > Bakiye)
        {
            Console.WriteLine("Yetersiz bakiye.");
        }
        else
        {
            Console.WriteLine("Lütfen geçerli bir miktar girin.");
        }
    }

    // Bakiye Görüntüleme Metodu
    public void BakiyeGoster()
    {
        Console.WriteLine($"Hesap Numarası: {HesapNumarasi}, Güncel Bakiye: {Bakiye} TL");
    }
}

class Program
{
    static void Main()
    {
        // Yeni bir BankaHesabi nesnesi oluşturuyoruz
        BankaHesabi hesap = new BankaHesabi("1234567890", 1000);

        // Mevcut bakiyeyi göster
        hesap.BakiyeGoster();

        // Para yatırma işlemi
        hesap.ParaYatir(500);

        // Para çekme işlemi
        hesap.ParaCek(200);

        // Yetersiz bakiye durumu
        hesap.ParaCek(2000);

        // Güncel bakiyeyi tekrar göster
        hesap.BakiyeGoster();

        // Konsol ekranını açık tutar
        Console.ReadLine();
    }
}
