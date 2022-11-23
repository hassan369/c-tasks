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
            int num1 = 4;
            int num2 = 5;
            if (num1 < num2)
            {
                Console.WriteLine(num1);
            } else
            {
                Console.WriteLine(num2);
            }

            //task2
            int num3 = 4;
            
            if (num3 < 0)
            {
                Console.WriteLine("-");
            }
            else
            {
                Console.WriteLine("+");
            }

            //task3
            int x = 4;
            int y = 2;
            int z = 3;

            if (x>y && x>z)
            {
                    if (y>z)
                    {
                        Console.WriteLine(x + ", " + y + ", " +z);
                    }
                    else
                    {
                        Console.WriteLine(x + ", " + z + ", " +y);
                    }
            }
            else if (y>x && y >z)
            {
                    if (x>z)
                    {
                         Console.WriteLine(y + ", " + x + ", " +z);
                    }
                    else
                    {
                         Console.WriteLine(y + ", " + z + ", " +x);
                    }
            }
            else if (z>x && z>y)
            {
                    if (x>y)
                    {
                        Console.WriteLine(z + ", " + x + ", " +y);
                    }
                    else
                    {
                        Console.WriteLine(z + ", " + y + ", " +x);
                    }


            }

            //task4
            int num11 = 3;
            int num12 = 6;
            int num13 = 11;
            int num14 = 8;
            int num15 = 9;
            if(num11 >= num12 && num11 >= num13 && num11 >= num14 && num11 >= num15)
            {
                Console.WriteLine(num11);
            } else if (num12 >= num11 && num12 >= num13 && num12 >= num14 && num12 >= num15)
            {
                Console.WriteLine(num12);
            } else if (num13 >= num12 && num13 >= num11 && num13 >= num14 && num13 >= num15)
            {
                Console.WriteLine(num13);
            } else if (num14 >= num12 && num14 >= num13 && num14 >= num11 && num14 >= num15)
            {
                Console.WriteLine(num14);
            } else if (num15 >= num12 && num15 >= num13 && num15 >= num14 && num15 >= num11)
            {
                Console.WriteLine(num15);
            }
            //task5
            Console.WriteLine("enter kilomerter per hour: ");
            int km = Convert.ToInt16(Console.ReadLine()) ;
            Console.WriteLine (km * 0.6213711);
            //task6
            Console.WriteLine ("input hours");
            int hours = Convert.ToInt16(Console.ReadLine()) ;
            Console.WriteLine("input minutes");
            int minutes = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine(hours * 60 + minutes);

            //task 7
            Console.WriteLine("enter minutes");
            int minutess = Convert.ToInt16(Console.ReadLine()) ;
            Console.WriteLine($"{minutess/60}Hours, {minutess%60} Minutes");

            //task 8
            string[] names = { "ahmad ahmad", "ali ali ali ", "sameer ssssseef", "hassan ayasrah", "nsreen daraghmeh" };
            Console.WriteLine($"{names[0].Substring(4)}\n{names[1].Substring(6)}\n {names[2].Substring(2,5)}\n {names[3].Substring(6,7)}\n{names[4].Substring(0,6)}");
        }
    }
}
