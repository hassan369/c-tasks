using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //task1
            int[] ARR = { 1, 7, 9, 45 };
            string[] arr2 = { "Str", "alex", "moh" };
            string[] arr3 = { "the", "fox", "over", "lazy", "dog" };

            //task2
            //index of banana is 1 
            //index of tomato is 0


            //task3
            string[] foods = { "mansaf", "kabsah", "dawalii", "maghlobah", "seaFood" };
            string[] sports = { "football", "basketball", "swime" };
            string[] movies = { "lock stock and two smoking parlies", "black swan", "showshanic readimpitoin", "night clup" };

            foreach (string f in foods)
            {
                Console.WriteLine(f);
            }
            foreach (string s in sports)
            {
                Console.WriteLine(s);
            }
            foreach (string m in movies)
            {
                Console.WriteLine(m);
            }

            //task4
            Console.Write("Please enter numbers, comma-separated: ");
            var numbers = Console.ReadLine()
                .Split(',')
                .Select(x => Convert.ToDouble(x))
                .ToArray();
            Console.WriteLine($"the sum of three numbers {numbers[0] + numbers[1] + numbers[2]}");

            //task5
            int odd = 0;
            int sumOfOdd = 0;
            Console.Write("The odd numbers are");
            for (int i = 1; i <= 100; i += 2)
            {
                Console.Write(i + " ");
            }
            Console.Write("\nThe sum of odd Numbers is:");
            for (int i = 1; i <= 100; i += 2)
            {
                sumOfOdd += i;

            }
            Console.WriteLine(sumOfOdd);

            //task6
            int range = 4;
            for (int i = 0; i < range; i++)
            {
                for (int j = range - i; j > 0; j--)
                {
                    Console.Write(" ");
                }
                for (int s = 0; s <= i; s++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine("\n");

            }

            //task7

            int range2 = 4;
            int num = 1;
            {
                for (int i = 0; i < range2; i++)
                {
                    for (int j = range - i; j > 0; j--)
                    {
                        Console.Write(" ");
                    }
                    for (int s = 1; s <= i + 1; s++)
                    {
                        Console.Write(num + " ");
                        num++;
                    }
                    Console.WriteLine("\n");

                }


            }
        }
    }
}
