using System;

namespace Abstract
{

    // abstract class
    abstract class Sekiller
    {

        // abstract metot
        public abstract int alan();
    }

    // Sekiller sınıfından kare sınıfı kalıtım oluşturma
    class kare : Sekiller
    {

        // veri oluşturma
        private int kenar;

        // kare sınıfına ait metot
        public kare(int x = 0)
        {
            kenar = x;
        }

        // override ile Sekiller sınıfının 
        // soyutlama yöntemi geçersiz hale getirilir.
        public override int alan()
        {
            Console.Write("Karenin alani : ");
            return (kenar * kenar);
        }
    }

    // Driver Class
    class FKA
    {

        // Main Metot
        static void Main(string[] args)
        {

            // Kare sınıfındaki veriye
            // Sekiller sınıfına ait
            // referans verme
             Sekiller sh = new kare();

            // MEtot Çağırma
            double result = sh.alan();

            Console.WriteLine("{0}", result);

        }
    }
}
