using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Employee
    {
        public string name;
        public int birthday;
        public int id;

        public Employee() { }
        public Employee(string Aname, int Abirthday, int Aid) 
        {
            name = Aname;
            birthday = Abirthday;
            id = Aid;
        }
        public virtual void Age ()
        {
            Console.WriteLine("Employee name is" + Convert.ToString(2022 - birthday) );
        }
    }
    class Manager : Employee
    {
        public void fullInformation()
        {
            Console.WriteLine(name + " " + birthday + " " + id);
        }
        public Manager(string Aname, int Abirthday, int Aid)
        {
            name = Aname;
            birthday = Abirthday;
            id = Aid;
        }
        public override void Age()
        {
            Console.WriteLine("Maneger name is" + Convert.ToString(2022 - birthday));
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Employee hassan = new Employee("hassan", 1998, 04);
            hassan.Age();
            Manager Ahmad = new Manager("ahmad", 1987, 01);
            Ahmad.Age();
        }
    }
}
