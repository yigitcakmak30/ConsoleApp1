using Ders2;
using System;

namespace ClassSturctures
{

    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Adi = "Elma";
            product1.Fiyati = 12;
            product1.Aciklama = "Amasya elması";

            Product product2 = new Product();
            product2.Adi = "Kivi";
            product2.Fiyati = 15;
            product2.Aciklama = "Ayının kivisi";

            Product[] urunler = new Product[] {product1,product2};

            foreach (Product urun in urunler)
            {
                Console.WriteLine(urun.Adi + "         |");
                Console.WriteLine(urun.Fiyati + " TL        |");
                Console.WriteLine(urun.Aciklama + "|");
                Console.WriteLine("-------------+");
            }
            Console.WriteLine("---------Metodlar--------");

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(product2);
        
        }
    }
}