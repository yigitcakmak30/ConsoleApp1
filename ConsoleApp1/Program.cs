using System;

namespace ConsoleApp1
{

    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            string isimEtiketi = "Yiğit";
            bool sistemeGirisYapmisMi = false;
            double dolarDun = 35.65;
            double dolarBugun = 35.75;
            Console.WriteLine("Sayi giriniz:");
            num1 = Console.Read();
            Console.WriteLine("Sayi giriniz:");
            num2 = Console.Read();
            Console.WriteLine(num1 + num2);
            if (dolarDun<dolarBugun)
            {
                Console.WriteLine("Dolar dün");
                Console.WriteLine(dolarDun);
                Console.WriteLine("Dolar bugun");
                Console.WriteLine(dolarBugun);
                Console.WriteLine("Artış oku");
            }
            else if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Dolar dün");
                Console.WriteLine(dolarDun);
                Console.WriteLine("Dolar bugun");
                Console.WriteLine(dolarBugun);
                Console.WriteLine("Azalış oku");
            }
            else
            {
                Console.WriteLine("Dolar dün");
                Console.WriteLine(dolarDun);
                Console.WriteLine("Dolar bugun");
                Console.WriteLine(dolarBugun);
                Console.WriteLine("Sabit ok");
            }
        }
    }
}