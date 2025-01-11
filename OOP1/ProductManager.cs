using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    class ProductManager
    {
        public void Add(Product product)
        {
            Console.WriteLine(product.ProductName + " added to cart " + product.UnitPrice + " TL");
        }

        public void Update(Product product)
        {
            product.UnitsInStock--;

            Console.WriteLine("Units in stock updated, new count is --> " + product.UnitsInStock);
        }

        public int Topla(int sayi1, int sayi2)
        {
            // int ve return ile deger ataması yapılabilir
            return sayi1 + sayi2;
        }
        public void Topla2(int sayi1, int sayi2)
        {
            // void metotlarda sadece cıktı alınır atama yapılmaz
            Console.WriteLine(sayi1+sayi2);
        }
    }
}
