using System;

namespace fundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = 1;
            int end = 255;
            for (int i = start; i <= end; i++)
            {
                Console.WriteLine(i);
            }

            int start = 1;
            int end = 100;
            for (int i = start; i <= end; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    continue;
                }
                else if (i % 3 == 0 || i % 5 == 0)
                {
                    Console.WriteLine(i);
                }
            }


            int start = 1;
            int end = 100;
            for (int i = start; i <= end; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine($" {i} FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine($" {i} Fizz");
                }

                else if (i % 5 == 0)
                {
                    Console.WriteLine($" {i} Buzz");
                }
            }

            // while loops
            int i = 1;
            while (i <= 255)
            {
                Console.WriteLine(i);
                i = i + 1;
            }

            int i = 1;
            while (i < 101)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    i = i + 1;
                }
                else if (i % 3 == 0 || i % 5 == 0)
                {
                    Console.WriteLine(i);
                    i = i + 1;
                }
                else
                {
                    i = i + 1;
                }
            }


            int i = 1;
            while (i < 101)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine($" {i} FizzBuzz");
                    i = i + 1;
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine($" {i} Fizz");
                    i = i + 1;
                }

                else if (i % 5 == 0)
                {
                    Console.WriteLine($" {i} Buzz");
                    i = i + 1;
                }
                else
                {
                    i = i + 1;
                }
            }

        }
    }
}
