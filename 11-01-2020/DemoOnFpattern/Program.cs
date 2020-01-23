using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoOnFpattern
{
    interface IFactory
    {
        void manfacture(int cnt);
    }
    class Bike : IFactory
    {
        public void manfacture(int cnt)
        {
            Console.WriteLine("bike manfacutring no:" + cnt);

        }
    }
    class car : IFactory
    {
        public void manfacture(int cnt)
        {
            Console.WriteLine("car manfacutring no:" + cnt);

        }
    }
     abstract class VehicleFactory
    {
        public abstract IFactory Generate(string type);

    }

    class ConcreteVehicleFactory : VehicleFactory
    {
        public override IFactory Generate(string type)
        {

            if (type == "a") return new Bike();


            else return new car();


        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            VehicleFactory obj = new ConcreteVehicleFactory();
            IFactory f = obj.Generate("a");
            f.manfacture(10);
            f = obj.Generate("b");
            f.manfacture(10);
            Console.ReadKey();
        }
    }
}
