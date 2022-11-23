using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static double[] SumAndAvarage(double[] numbers)
        {
            double sum = 0;
            double avarage = 0;
            int counter = 0;
            foreach(int i in numbers)
            {
                counter++;
                sum += i;
            }
            avarage = sum / counter;
            double[] result = { sum, avarage };
            return result;
             
        }
        static void cube(int[] numbers)
        {
            Console.Write($"The cube of numbers are : ");
            double numberi;
            foreach (int i in numbers)
            {
                numberi = Math.Pow(i, 3);
                Console.Write($"{numberi} ");
            }
        }
        static void getYears(int[] years) {
            foreach (int i in years)
            {
                string resYears = "";
                if (i > 1950)
                {
                    resYears += $"{i} ";

                }
                Console.Write(resYears + " ");
                
            }
        }

        static int ageInDays(int age) {
            return age * 365;
        }

        static int animals(int checken, int cows, int cheep)
        {
            return checken * 2 + cows * 4 + cheep * 4;
        }

        static bool isLeap(int year)
        {
            for (int i = 1900; i <= 2024; i += 4) {
                if (year == i)
                {
                    return true;
                }
            }
            return false;
            //return ((year % 4 == 0) && (year % 100 != 0)) || (year % 400 == 0);
        }

        static bool isPrime(int num) {
            for (int i = 2; i < num; i++) { 
            if(num % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        static int numberOfChar(string words) {
            int counter = 0;
        foreach(char i in words)
            {
                
                if(i == ' ')
                {
                    continue;
                }
                counter++;
            }
            return counter;
        }

        static int powHassan(int i, int p) {
            int sum = i;
            for(int k = 1; k<p; k++)
            {
                sum *= i;
            }
            return sum;
        }

        static bool isValidLoged(string[] CurrentUser)
        {
            string[] user1 = { "razan", "razan123" };
            string[] user2 = { "hassan", "hassan123" };
            if (CurrentUser[0] == user1[0] && CurrentUser[1] == user1[1] || CurrentUser[0] == user2[0] && CurrentUser[1] == user2[1])
            {
                return true;
            }
            else
            {
                return false;
            }
        }
         
        static void Main(string[] args)
        {
            Console.WriteLine("Task 1");
            //task1
            Console.Write("Enter 10 numbers saperated with space: ");
            string[] arr = Console.ReadLine().Split(' ');
            double[] ints = Array.ConvertAll(arr, s => Convert.ToDouble(s));
            double[] res = SumAndAvarage(ints);
            double sum = res[0];
            double avarage = res[1];
            Console.WriteLine($"the sum is {sum} and the avarage is {avarage}");

            Console.WriteLine("Task 2");
            //task2
            Console.Write("Enter 5 numbers saperated with space: ");
            string[] arr2 = Console.ReadLine().Split(' ');
            int[] ints2 = Array.ConvertAll(arr2, s => Convert.ToInt32(s));
            cube(ints2);


            Console.WriteLine();
            Console.WriteLine("Task 3");
            //task3
            int[] years = { 1763, 1972, 1925, 1916, 1984, 1124, 1950, 2020 };
            getYears(years);

            Console.WriteLine();
            Console.WriteLine("Task 4");
            //task4
            Console.WriteLine("what is your age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            int resAge = ageInDays(age);
            Console.WriteLine($"the age in days is {resAge}");


            Console.WriteLine("Task 5");
            //task5
            Console.Write("how many checkens do you have: ");
            int checken = Convert.ToInt32(Console.ReadLine());
            Console.Write("how many cows do you have: ");
            int cows = Convert.ToInt32(Console.ReadLine());
            Console.Write("how many cheep do you have: ");
            int cheep = Convert.ToInt32(Console.ReadLine());
            int sumOfLegs = animals(checken, cows, cheep);
            Console.WriteLine($"the sum of animal's legs are: {sumOfLegs}");

            Console.WriteLine("Task 6");
            //task6
            Console.Write("enter userName: ");
            string userName = Console.ReadLine();
            Console.Write("enter password: ");
            string password = Console.ReadLine();

            string[] currentUser = { userName, password };
            if (isValidLoged(currentUser))
            {
                Console.WriteLine("Loged In");
            } else
            {
                Console.WriteLine("No account for this user");
            }

            Console.WriteLine("Task 7");
            //task7
            int powRes = powHassan(2, 5);
            Console.Write(powRes);

            Console.WriteLine();
            Console.WriteLine("Task 8");
            //task8
            Console.WriteLine("enter year between 1900 and 2024: ");
            int leapCheck = Convert.ToInt32(Console.ReadLine());

            if (isLeap(leapCheck))
            {
                Console.WriteLine("leap year");
            }
            else
            {
                Console.WriteLine("not leap year");
            }

            Console.WriteLine("Task 9");
            //task9
            Console.WriteLine("enter number to check if prime: ");
            int prime = Convert.ToInt32(Console.ReadLine());
            if (isPrime(prime))
            {
                Console.WriteLine("the number is prime");
            }
            else
            {
                Console.WriteLine("the number is not prime");
            }

            Console.WriteLine("Task 10");
            //task10
            Console.Write("enter sentence to know how many char in it: ");
            string wordToCheck = Console.ReadLine();
            int counterForChar = numberOfChar(wordToCheck);
            Console.WriteLine($"the number of chars in sentence are: {counterForChar}");
        }
    }
}
