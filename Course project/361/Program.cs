using System;

namespace _361
{
    class Program
        /*
         Съставете програма, която при всяко срещане на низа А*А в низа S го заменя с низа "sqr(A)". 
         Забележете, че низът А*А може да се среща няколко пъти.
         */ 
    {
        static void Main(string[] args)
        {
            RepeatingStrings();
        }

        public static void RepeatingStrings()
        {
            string word = "A*AasdfA*AA*Aasdf";
            string repeatingWord = "";

            for (int i = 0; i < word.Length - 2; i++)
            {
                for (int j = i; j < i + 3; j++)
                {
                    repeatingWord += word[j];
                }
                if (repeatingWord == "A*A")
                {
                    repeatingWord = "";
                    word = word.Remove(i, 3).Insert(i, "sqr(A)");
                }
                repeatingWord = "";
            }

            Console.WriteLine(word);
        }
    }
}
