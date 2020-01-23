using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton s1 = Singleton.GetInstance;
            s1.printDetails("hi");
            Singleton s2 = Singleton.GetInstance;
            s1.printDetails("hello");
            Console.ReadKey();
        }
    }
}
