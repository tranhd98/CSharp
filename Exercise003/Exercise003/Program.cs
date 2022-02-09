using System;

namespace Exercise003
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1/");
            for (int i = 0; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }

            // 2/
            //int max = 50; for (byte i = 0; i < max; i++) { WriteLine(i); };
            // the program runs infinitely.
            // The problem is int max and byte i is different type so can't compare in condition.
            //  . Change byte to int value.
            //  . Need to be Console.WriteLine(i)
            Console.WriteLine();
            Console.WriteLine("3/");
            Console.WriteLine("Guessing number");
            int correctNumber = new Random().Next(3) + 1;
            while (true)
            {
                Console.Write("Guess number: ");
                int guessedNumber = int.Parse(Console.ReadLine());
                if (guessedNumber > 3 || guessedNumber < 1)
                {
                    Console.WriteLine("Out range");
                }
                else if (guessedNumber > correctNumber)
                {
                    Console.WriteLine("High");
                }
                else if (guessedNumber < correctNumber)
                {
                    Console.WriteLine("Low");
                }
                else
                {
                    Console.WriteLine("correct");
                    break;
                }
            }
            Console.WriteLine();
            Console.WriteLine("Print-a-Pyramid");
            int step = 1;
            int start = 1;
            for(int i = 0; i < step; i++)
            {
                for(int j = 0; j < step - i ; j++)
                {
                    Console.Write(" ");
                }

                for(int j = 0; j < start; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
                start += 2;
            }
            Console.WriteLine();
            Console.WriteLine("4/");
            Console.WriteLine("Calculate days old the person");
            DateTime dt = new DateTime(1998, 08, 20);
            DateTime todaysDate = DateTime.Today;
            int yearDifference = todaysDate.Year - dt.Year;
            int monthDifference = todaysDate.Month - dt.Month;
            int daysDifference = todaysDate.Day - dt.Day;
            daysDifference += ((int)(yearDifference * 385.2425) + (int)(monthDifference * 30.436875));
            Console.WriteLine(daysDifference);
            Console.WriteLine();
            Console.WriteLine("5");
            DateTime now = DateTime.Now;
            if(now.Hour < 12 && now.Hour >= 5)
            {
                Console.WriteLine("Good Morning");
            }
            if(now.Hour >= 12 && now.Hour < 16)
            {
                Console.WriteLine("Good Afternoon");
            }
            if(now.Hour >= 16 && now.Hour < 21)
            {
                Console.WriteLine("Good Evening");
            }
            if((now.Hour >= 21 && now.Hour < 24) ||(now.Hour >= 0 && now.Hour < 5))
            {
                Console.WriteLine("Good Night");
            }
            Console.WriteLine();
            Console.WriteLine("6/");
            Console.WriteLine("a program that prints the result of counting up to 24 using four different increments. ");
            for(int i = 1; i<= 4; i++)
            {
                for(int j = 0; j <= 24; j += i)
                {
                    Console.Write(j);
                    if (j < 24) {
                        Console.Write(",");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
