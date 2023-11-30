namespace library_management_system;

public class YaziliEser : IYazdirilabilir
{
    public int KitapID { get; set; }
    public string Ad { get; set; }
    public string Yazar { get; set; }
    public int YayinYili { get; set; }

    public virtual void Yazdir()
    {
        Console.WriteLine($"Kitap ID: {KitapID}, Ad: {Ad}, Yazar: {Yazar}, Yayın Yılı: {YayinYili}");
    }
}