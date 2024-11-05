using System;

class Kisi
{
    // Özellikler
    public string Ad { get; private set; }
    public string Soyad { get; private set; }
    public string TelefonNumarasi { get; private set; }

    // Yapıcı Metot
    public Kisi(string ad, string soyad, string telefonNumarasi)
    {
        Ad = ad;
        Soyad = soyad;
        TelefonNumarasi = telefonNumarasi;
    }

    // Kişinin bilgilerini döndüren metot
    public string KisiBilgisi()
    {
        return $"Tam Ad: {Ad} {Soyad}, Telefon Numarası: {TelefonNumarasi}";
    }
}

class Program
{
    static void Main()
    {
        // Yeni bir Kisi nesnesi oluşturuyoruz
        Kisi kisi = new Kisi("Ali", "Yılmaz", "555-123-4567");

        // Kişinin bilgilerini görüntüle
        Console.WriteLine(kisi.KisiBilgisi());

        // Konsol ekranını açık tutar
        Console.ReadLine();
    }
}
