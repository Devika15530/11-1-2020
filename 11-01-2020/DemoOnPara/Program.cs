using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoOnPara
{
    class Calci
    {
        public void Add(params int[] x)
        {
            int res = 0;
            foreach (int i in x)
                res += i;
            res = x.Sum(e => e);

            
            Console.WriteLine(res);




        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Calci c = new Calci();
            c.Add(10, 40, 50);

            Console.ReadKey();

        }
    }
}
