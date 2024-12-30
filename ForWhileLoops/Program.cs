using System;

namespace ForWhileLoops
{

    class Program
    {
        static void Main(string[] args)
        {
            //array ve for dongulerını ıc ıce kullanıp statıklık saglamak
            string[] kurslar = new string[] {"C# Kursu",
                "Python kursu",
                "Java kursu",
                "JavaScript kursu",
                "GoLang kursu",
                "Rust kursu"};

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            //for dongusu ıle faktoriyel hesaplama
            int j = 1;
            int faktoriyel = 5;
            for (int x = 1; x <= faktoriyel; x++)
            {
                j = x * j;
                Console.WriteLine(j);
            }

            //foreach dongusu: array temellı yapıları tek tek donmeye yarar, usttekı for array ıc ıce kısmını kolaylastırmak ıcın kullanılır
            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }
        }
    }
}