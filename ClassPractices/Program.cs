using System;

namespace ClassPractices
{
    class Program
    {
        static void Main(string[] args)
        {
            Kurs kurs1 = new Kurs();
            kurs1.kursAdi = "Python";
            kurs1.kursEgitmen = "Yakın Kampüs";
            kurs1.kursBittiMi = false;
            kurs1.kursBitirmeOrani = 18;

            Kurs kurs2 = new Kurs();
            kurs2.kursAdi = "C#";
            kurs2.kursEgitmen = "Engin Demirog";
            kurs2.kursBittiMi = false;
            kurs2.kursBitirmeOrani = 72;

            Kurs kurs3 = new Kurs();
            kurs3.kursAdi = "C++";
            kurs3.kursEgitmen = "Giraffe Academy";
            kurs3.kursBittiMi = true;
            kurs3.kursBitirmeOrani = 100;
            
            Kurs kurs4 = new Kurs();
            kurs4.kursAdi = "GoLang";
            kurs4.kursEgitmen = "YigitCakmak";
            kurs4.kursBittiMi = false;
            kurs4.kursBitirmeOrani = 32;


            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3, kurs4 };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.kursAdi + " " + kurs.kursEgitmen + " " + kurs.kursBittiMi + " %" + kurs.kursBitirmeOrani);
            }
        }
    }
    class Kurs
    {
        public string kursAdi { get; set; }
        public string kursEgitmen { get; set; }
        public bool kursBittiMi { get; set; }
        public int kursBitirmeOrani { get; set; }
    }




}