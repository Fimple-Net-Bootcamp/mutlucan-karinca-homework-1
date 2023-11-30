using library_management_system;

Kutuphane kutuphane = new Kutuphane();

Kitap kitap1 = new Kitap { KitapID = 1, Ad = "Suç ve Ceza", Yazar = "Fyodor Dostoyevski", YayinYili = 1866, Tur = "Roman" };
Kitap kitap2 = new Kitap { KitapID = 2, Ad = "İnsan Neyle Yaşar?", Yazar = "Tolstoy", YayinYili = 1885, Tur = "Kurgu" };
Kitap kitap3 = new Kitap { KitapID = 3, Ad = "Satranç", Yazar = "Stefan Zweig", YayinYili = 1943, Tur = "Kurgu" };

Uye uye1 = new Uye(1, "Ahmet", "Yilmaz");
Uye uye2 = new Uye(2, "Ayse", "Kaya");

kutuphane.KitapEkle(kitap1);
kutuphane.KitapEkle(kitap2);
kutuphane.KitapEkle(kitap3);

kutuphane.UyeEkle(uye1);
kutuphane.UyeEkle(uye2);

Console.WriteLine("------------------------------");
kutuphane.TumKitaplariListele();
Console.WriteLine("------------------------------");
kutuphane.OduncVer(uye1, kitap2);
Console.WriteLine("------------------------------");
kutuphane.OduncVer(uye2, kitap3);
Console.WriteLine("------------------------------");
kutuphane.OduncVer(uye1, kitap3);
Console.WriteLine("------------------------------");
kutuphane.TumKitaplariListele();
Console.WriteLine("------------------------------");
kutuphane.TumUyeleriListele();
Console.WriteLine("------------------------------");
kutuphane.IadeEt(uye1, kitap2);
Console.WriteLine("------------------------------");
kutuphane.TumKitaplariListele();

