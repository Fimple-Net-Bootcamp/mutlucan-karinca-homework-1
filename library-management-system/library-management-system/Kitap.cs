namespace library_management_system;

public class Kitap : YaziliEser
{
    public string Tur { get; set; }
    public override void Yazdir()
    {
        Console.WriteLine($"Kitap ID: {KitapID}, Ad: {Ad}, Yazar: {Yazar}, Yayın Yılı: {YayinYili}, Tur: {Tur} ");
    }
}