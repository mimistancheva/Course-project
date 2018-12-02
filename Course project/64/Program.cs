using System;

namespace _64
{
    class Program
    {
        /*
         Да се състави програма, която да пресмята лицето на една от фигурите: кръг, триъгълник или правоъгълник.
         */ 
        static void Main(string[] args)
        {
            Console.WriteLine("Програма за намиране лице на правоъгълник");
            int a, b, S;
            Console.Write("Въведете а: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Въведете b: ");
            b = int.Parse(Console.ReadLine());
            S = a * b;
            Console.WriteLine("Лицето е равно на {0}", S);

            {
                Console.WriteLine("Програма за намиране лице на кръг");
            }

            Console.Write("Въведете радиус r = ");
            var r = double.Parse(Console.ReadLine());
            Console.WriteLine("Area = " + Math.PI * r * r);

        }
    }
}
