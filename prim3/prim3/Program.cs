using System;

namespace ConsoleApp22
{
    class Program
    {
        static void Main(string[] args)
        {
            int inp;
            do
            {
                Console.Write("Input a number to be the limit your Sieve of Erastothenes , and i will print all prime numbers : ");
                inp=Convert.ToInt32(Console.ReadLine());
            } while (inp < 2);

            bool[] primenums = new bool[inp];
            for (int i = 0; i < inp; i++)
            {
                primenums[i] = true;
            }

            for (int i = 2; i < inp; i++)
            {
                if (primenums[i - 1])
                {
                    for (int t = i * i; t < inp; t += i)
                    {
                        primenums[t - 1] = false;
                    }
                }
            }
            Console.WriteLine("\nthe result is : \n");
            for (int i = 2; i < inp; i++)
                if (primenums[i - 1])
                { Console.Write($" {i} "); }





        }
    }
}