﻿using System;
using System.Collections.Generic;

namespace Collections
{

    class Program
    {
        static void Main(string[] args)
        {
            //string[] isimler = new string[] {"Engin","Mesut","Murat","Ahmet" };
            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            //Console.WriteLine(isimler[3]);

            //isimler = new string[5]; // string arrayi sıfırlandı ve yeni arrayde sadece 4. indexe atama yapildi asagıda 0. index bos dundurulur
            //isimler[4] = "İlker";
            //Console.WriteLine(isimler[4]);
            //Console.WriteLine(isimler[0]);

            List<string> isimler2 = new List<string> {"Engin", "Mesut", "Murat", "Ahmet" };
            foreach (var ders in dersler)
            {
                Console.WriteLine(ders);
            }
            Console.WriteLine();
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            isimler2.Add("Rıza");
            Console.WriteLine(isimler2[4]);
        }
    }
}