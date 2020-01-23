
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoIndexer
{
    class Program
    {
        static void Main(string[] args)
        {
            Car c = new Car();
            c.Year = 2019;
            c[0] = "maruth";
            c[1] = "benz";
            c[2] = "honda";
            c.display();
            Console.ReadKey();
        }
    }
}
