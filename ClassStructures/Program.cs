using System;

namespace ClassStructures
{

    class Program
    {
        static void Main(string[] args)
        {
            Kurs kurs1 = new Kurs();
            kurs1.kursAdi = "C#";
            kurs1.kursEgitmeni = "Engin Demirog";
            kurs1.kursIzlenmeOrani = 20;

            Kurs kurs2 = new Kurs();
            kurs2.kursAdi = "Python";
            kurs2.kursEgitmeni = "Mustafa Murat Coskun";
            kurs2.kursIzlenmeOrani = 100;

            Kurs kurs3 = new Kurs();
            kurs3.kursAdi = "Hacking";
            kurs3.kursEgitmeni = "Atil Samancioglu";
            kurs3.kursIzlenmeOrani = 10;

            //Console.WriteLine(kurs1.kursAdi + " " + kurs1.kursEgitmeni + " %" + kurs1.kursIzlenmeOrani);
            //Console.WriteLine("");
            //Console.WriteLine(kurs2.kursAdi + " " + kurs2.kursEgitmeni + " %" + kurs2.kursIzlenmeOrani);
            //Console.WriteLine("");
            //Console.WriteLine(kurs3.kursAdi + " " + kurs3.kursEgitmeni + " %" + kurs3.kursIzlenmeOrani);
            //Console.WriteLine("");
            
            Kurs[] kurslar = new Kurs[] {kurs1,kurs2,kurs3};
            foreach (Kurs kurs in kurslar)
            {
                Console.WriteLine(kurs.kursAdi + " " + kurs.kursEgitmeni + " %" + kurs.kursIzlenmeOrani);
                
            }
        }
    }
    class Kurs
    {
        public string kursAdi { get; set; }

        public string kursEgitmeni { get; set; }
        public int kursIzlenmeOrani { get; set; }
    }
}