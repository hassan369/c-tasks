using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //task1
            Console.WriteLine("Enter Name: ");
            string name = Console.ReadLine();
            Console.WriteLine("name is " + name);

            //task 2
            double num1 = 5.7;
            string name2 = "Hassan";
            char letter = 'a';
            bool isTrue = false;
            int num2 = 0;
            const double pi = 3.14;
            Console.WriteLine(num1 +" " + name2 + " " + letter + " " + isTrue + " " + num2 + " " + pi);

            //task 3 
            string[] car = {"hyundai", "kia", "mercedece" };
            Console.WriteLine(car[0]);
            Console.WriteLine(car[1]);
            Console.WriteLine(car[2]);

            //task 4
            Console.WriteLine("Enter firstName: ");
            string fname = Console.ReadLine();

            Console.WriteLine("Enter lastName: ");
            string lname = Console.ReadLine();

            Console.WriteLine("Enter your year of birth: ");
            string birth = Console.ReadLine();
            Console.WriteLine(fname + " "+ lname + " "+ birth);

            //task 5
            int[] numbers = { 1,1,2,3,4,5,6,7,8,9 };
            Console.WriteLine(numbers[0]);
            Console.WriteLine(numbers[1]);
            Console.WriteLine(numbers[2]);
            Console.WriteLine(numbers[3]);
            Console.WriteLine(numbers[4]);
            Console.WriteLine(numbers[5]);
            Console.WriteLine(numbers[6]);
            Console.WriteLine(numbers[7]);
            Console.WriteLine(numbers[8]);
            Console.WriteLine(numbers[9]);

            //task 6
            int[] numbers2 = { 2, 5, 8};
            Console.WriteLine("Sum of all elements stored in the array is: " + numbers2[0] + numbers2[1]+ numbers2[2]);



        }
    }
}
