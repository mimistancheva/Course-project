using System;

namespace _87v
{
    class Program
    {
        static void Main(string[] args)
            /*
             Отпечатване на фигура.
             */ 
        {
            DrawTriangle(7);
        }

        public static void DrawTriangle(int rows)
        {
            int i;
            int j;
            int k;

            for (i = 1; i <= rows; i++)
            {
                for (j = 1; j <= rows - i; j++)
                {
                    Console.Write(" ");
                }
                for (k = 1; k <= i; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
            Console.ReadLine();
        }
    }
}
