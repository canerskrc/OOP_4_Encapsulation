/*
using System;

public class Kapsulleme
{

    //Bu kısımdaki verilere yalnızca Kapsulleme 
    // isimli temel(ana) sınıf tarafından erişilir.
    private String Isım;
    private int Yas;

    // Erişimcileri kullanarak (get,set)
    // Kisi adı değeri alınır(get) ve ayarlanır(set).
    public String KisiAdi
    {

        get { return Isım; }

        set { Isım = value; }
    }

    // Yukarıda olduğu gibi kisi yaşı 
    // değeri alınır ve ayarlanır.
    public int KisiYasi
    {

        get { return Yas; }

        set { Yas = value; }
    }
}

// Driver Class
class FKA
{

    // Main Method
    static public void Main()
    {

        // Nesne oluşturulur
        Kapsulleme obj = new Kapsulleme();

        // Kisi adı özelliğinin set erişimcisi
        // çağırılır. ve Kisi adına burada girilen
        // değer atanır.
        obj.KisiAdi = "Caner";
        

        
        

        // Yukarıda olduğu gibi kisi yasına 
        // set erişimcisi ile yaş değeri atanır
        obj.KisiYasi = 27;

        // Değişkenler ekranda gösterilir.
        Console.WriteLine(" Isim : " + obj.KisiAdi);
        Console.WriteLine(" Yaş : " + obj.KisiYasi);
    }
}
*/