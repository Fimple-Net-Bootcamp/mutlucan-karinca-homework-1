using library_management_system;

public class Kutuphane
{
    private List<Kitap> kitaplar;
    private List<Uye> uyeler;

    public Kutuphane()
    {
        kitaplar = new List<Kitap>();
        uyeler = new List<Uye>();
    }

    public void KitapEkle(Kitap kitap)
    {
        kitaplar.Add(kitap);
    }

    public void KitapSil(Kitap kitap)
    {
        kitaplar.Remove(kitap);
    }

    public void UyeEkle(Uye uye)
    {
        uyeler.Add(uye);
    }

    public void OduncVer(Uye uye, Kitap kitap)
    {
        foreach (var digerUye in uyeler)
        {
            if (digerUye != uye && digerUye.AldigiKitaplar.Contains(kitap))
            {
                Console.WriteLine($"Uyarı: {kitap.Ad} kitabı şu anda {digerUye.Ad} {digerUye.Soyad}'de.");
                return;
            }
        }

        uye.AldigiKitaplar.Add(kitap);
        kitaplar.Remove(kitap);
        Console.WriteLine($"{uye.Ad} {uye.Soyad}, {kitap.Ad} kitabını ödünç aldı.");
    }

    public void IadeEt(Uye uye, Kitap kitap)
    {
        uye.AldigiKitaplar.Remove(kitap);
        kitaplar.Add(kitap);
        Console.WriteLine($"{uye.Ad} {uye.Soyad}, {kitap.Ad} kitabını iade etti.");
    }

    public void TumKitaplariListele()
    {
        Console.WriteLine("Kütüphanedeki Tüm Kitaplar:");
        foreach (var kitap in kitaplar)
        {
            kitap.Yazdir();
        }
    }

    public void TumUyeleriListele()
    {
        Console.WriteLine("Kütüphanedeki Tüm Üyeler:");
        foreach (var uye in uyeler)
        {
            uye.Yazdir();
        }
    }
}

