using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Car
    {
        public int year;
        public string type;
        public string model;
        public int palletNum;
        public string color;

        public Car() { }
        public Car(int Ayear, string Atype, string Amodel, int ApalletNum, string Acolor)
        {
            this.year = Ayear;
            this.type = Atype;
            this.model = Amodel;
            this.palletNum = ApalletNum;
            this.color = Acolor;
        }
        public void start()
        {
            Console.WriteLine("the car is started");
        }
        public void stop()
        {
            Console.WriteLine("the car is stoped");
        }
    }
    public class Car2 : Car
    {
        public void Print()
        {
            Console.WriteLine(year + " "+ type + " " + model + " " + palletNum + " " + color );
        }
        public Car2(int Ayear, string Atype, string Amodel, int ApalletNum, string Acolor)
        {
            this.year = Ayear;
            this.type = Atype;
            this.model = Amodel;
            this.palletNum = ApalletNum;
            this.color = Acolor;
        }
    }
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Car hyundai = new Car(2001, "xd", "hyundai", 64642, "silver");
            Console.WriteLine(hyundai.year);
            Console.WriteLine(hyundai.type);
            Console.WriteLine(hyundai.model);
            Console.WriteLine(hyundai.palletNum);
            Console.WriteLine(hyundai.color);

            Car2 hyundai2 = new Car2(2001, "xd", "hyundai", 64642, "silver");
            hyundai2.Print();
        }
    }
}
