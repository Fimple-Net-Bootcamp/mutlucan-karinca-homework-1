namespace library_management_system;

public class Uye : IYazdirilabilir
{
    public int UyeID { get; set; }
    public string Ad { get; set; }
    public string Soyad { get; set; }
    public List<Kitap> AldigiKitaplar { get; set; }

    public Uye(int uyeID, string ad, string soyad)
    {
        UyeID = uyeID;
        Ad = ad;
        Soyad = soyad;
        AldigiKitaplar = new List<Kitap>();
    }

    public void Yazdir()
    {
        Console.WriteLine($"Üye ID: {UyeID}, Ad: {Ad}, Soyad: {Soyad}");
        Console.WriteLine("Aldığı Kitaplar:");
        foreach (var kitap in AldigiKitaplar)
        {
            kitap.Yazdir();
        }
    }
}