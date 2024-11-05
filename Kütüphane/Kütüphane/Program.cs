using System;
using System.Collections.Generic;

class Kitap
{
    // Kitap özellikleri
    public string Ad { get; private set; }
    public string Yazar { get; private set; }

    // Kitap yapıcı metodu
    public Kitap(string ad, string yazar)
    {
        Ad = ad;
        Yazar = yazar;
    }
}

class Kutuphane
{
    // Kitaplar özelliği - Kütüphanedeki kitapların listesini tutar
    private List<Kitap> Kitaplar;

    // Yapıcı Metot
    public Kutuphane()
    {
        Kitaplar = new List<Kitap>(); // Kitap listesi boş olarak başlatılır
    }

    // Kitap ekleme metodu
    public void KitapEkle(Kitap yeniKitap)
    {
        this.Kitaplar.Add(yeniKitap); // this anahtar kelimesi ile kütüphaneye ekleme
        Console.WriteLine($"{yeniKitap.Ad} kütüphaneye eklendi.");
    }

    // Kitapları listeleme metodu
    public void KitaplariListele()
    {
        Console.WriteLine("Kütüphanedeki Kitaplar:");
        foreach (var kitap in Kitaplar)
        {
            Console.WriteLine($"- {kitap.Ad} / Yazar: {kitap.Yazar}");
        }
    }
}

class Program
{
    static void Main()
    {
        // Yeni bir kütüphane nesnesi oluşturuyoruz
        Kutuphane kutuphane = new Kutuphane();

        // Kitapları oluşturup kütüphaneye ekliyoruz
        Kitap kitap1 = new Kitap("Sefiller", "Victor Hugo");
        Kitap kitap2 = new Kitap("Suç ve Ceza", "Fyodor Dostoyevski");

        kutuphane.KitapEkle(kitap1);
        kutuphane.KitapEkle(kitap2);

        // Kütüphanedeki kitapları listele
        kutuphane.KitaplariListele();

        // Konsol ekranını açık tutar
        Console.ReadLine();
    }
}
