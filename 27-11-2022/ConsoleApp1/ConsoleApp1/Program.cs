using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
  
   
    class Person
    {
        private int age;
        public string gender ;
        public string name;
        public string email;
        public int id;
        public string phone;


        public Person(int Aage, string Agender, string Aname, string Aemail, int Aid, string Aphone) { 
            age = Aage;
            if (Aage < 18 || Aage > 60)
            {
                Console.WriteLine("age is not between 18 and 60");
            }
           
            gender= Agender;
            name = Aname;
            email = Aemail;
            id = Aid;

            if (Aphone.Substring(0,3) == "077" || Aphone.Substring(0, 3) == "079" || Aphone.Substring(0, 3) == "078") {
                phone = Aphone;
            }
            else
            {
                Console.WriteLine("invalid phone number");
            }
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Person ahmad = new Person(90, "mail", "ahmad", "ahmad@gmail.com", 2 , "55544994");
            Console.WriteLine(ahmad.phone);

            
        }
    }
}
