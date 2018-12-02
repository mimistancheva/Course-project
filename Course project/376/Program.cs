using System;

namespace _376
{
    class Program
    {
        static void Main()
        {
            AvarageOfPositiveNumbers();
            AverageOfSevenNumbers();

            int numberA;
            int numberB;
            int numberC;

            do {

                Console.WriteLine("Input number A (A>0): ");
                numberA = int.Parse(Console.ReadLine());

                Console.WriteLine("Input number B (B>0): ");
                numberB = int.Parse(Console.ReadLine());

                Console.WriteLine("Input number C (C>0): ");
                numberC = int.Parse(Console.ReadLine());

            } while (numberA < 0 || numberB < 0 || numberC < 0);

            Console.WriteLine(Sred(Math.Abs(numberC - numberA)) - Sred(numberC+numberA));
        }
        /*
           Да се въведат от клавиатурата произволно число к и произволен брой
           ненулеви числа.За край на въвеждането служи 0. Да се отпечата 
           средноаритметичното на тези от тях, които са положителни.

        */
        public static void AvarageOfPositiveNumbers()
        {
            double sumOfPositiveNumbers = 0;
            double currentNumber;
            int positiveNumbersCount = 0;

            do
            {
                Console.WriteLine("Input a number: ");
                currentNumber = double.Parse(Console.ReadLine());

                if (currentNumber > 0)
                {
                    positiveNumbersCount++;
                    sumOfPositiveNumbers += currentNumber;
                }
            } while (currentNumber != 0);

            Console.WriteLine("Average of positive numbers: " + sumOfPositiveNumbers / positiveNumbersCount);
        }
        /* 
         Да се въведат от клавиатурата 7 числа. Да се намери и отпечата на екрана сумата на тези от тях,
         които отговарят на следното условие: да са отрицателни или по - големи от 300.
        */

        public static void AverageOfSevenNumbers()
        {
            int counter = 0;
            int negativeCounter = 0;
            double randomNumber;
            double sum = 0;

            do
            {
                Console.WriteLine("Input a number: ");
                randomNumber = double.Parse(Console.ReadLine());

                if (randomNumber < 0 || randomNumber > 300)
                {
                    sum = sum + randomNumber;
                    negativeCounter++;

                }
                counter++;
            } while (counter < 7);

            Console.WriteLine("Average number is: " + sum / negativeCounter);

        }
        /*
            Да се създаде метод Sred(k), който генерира к на брой случайни цели числа
            и като резултат връща средноаритметичното на тези от тях, които са в интервала 
            [10, 100]. В главния метод да се въведат 3 цели положителни числа a,b и с. Да се намери
            и отпечата: Sred(|c-b|) - Sred(c+a).
        */
        public static double Sred(int randomNumbers)
        {
            Random number = new Random();

            int newNumber = 0;
            int randomCounter = 0;

            double randomSum = 0;

            for (int i = 0; i < randomNumbers; i++)
            {
                newNumber = number.Next(1, 1000);

                if (newNumber >= 10 && newNumber <= 100)
                {
                    Console.WriteLine("In range: " + newNumber);
                    randomCounter++;
                    randomSum += newNumber;
                }
                else
                {
                    Console.WriteLine("Non-range numbers: " + newNumber);
                }
            }

            if (randomCounter == 0)
            {
                Console.WriteLine("No random numbers generated in this range.");
                return 0;
            }
            else
            {
                return randomSum / randomCounter;
            }
        }
    }
}
