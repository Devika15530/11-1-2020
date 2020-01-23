using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoPartial
{

    partial class ClassA//partiasl method can be created only partial class
    {
        partial void setData();//partial method decleration
        public void print()
        {
            Console.WriteLine("class a is printing");
            setData();//partial method should be private

        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            classA a = new classA();
            a.print();

        }
    }
}
