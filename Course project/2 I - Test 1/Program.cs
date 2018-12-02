using System;

namespace _2_I___Test_1
{
    class Program
    {
        /*
         Израз
         */
        static void Main(string[] args)
        {
            double x, y, z, t, l, n;

            Console.Write("x= ");
            x = double.Parse(Console.ReadLine());

            Console.Write("y= ");
            y = double.Parse(Console.ReadLine());

            Console.Write("z= ");
            z = double.Parse(Console.ReadLine());

            Console.Write("l= ");
            l = double.Parse(Console.ReadLine());

            Console.Write("n= ");
            n = double.Parse(Console.ReadLine());

            t = Math.Pow(x, 7) * y * z - (3 * 3) * (Math.Abs(x + Math.Pow(y, 1 / 4))) / Math.Pow(10, 7) + Math.Sqrt(l * n * 4);

            Console.WriteLine("Резултатът е равен на " + t);

        }
    }
}
