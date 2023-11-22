using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevicesAssignment
{
    internal class Program
    {
        static void Main()
        {
            // Demonstrate usage
            SmartPhone smartphone = new SmartPhone("MyPhone");
            smartphone.Connect();
            smartphone.Charge(60);
            Console.WriteLine(smartphone.Display());

            Console.WriteLine();

            Laptop laptop = new Laptop("MyLaptop");
            laptop.Connect();
            laptop.Charge(120);
            Console.WriteLine(laptop.Display());

            Console.ReadKey();
        }
    }
}
