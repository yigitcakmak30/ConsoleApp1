using System;

namespace Matematik
{

    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            num1 = Console.Read();
            num2 = Console.Read();

            DortIslem dortIslem = new DortIslem();
            dortIslem.Topla(5, 6);
            dortIslem.Topla(num1, num2);
            dortIslem.Topla(6, 9);
        }
    }
}