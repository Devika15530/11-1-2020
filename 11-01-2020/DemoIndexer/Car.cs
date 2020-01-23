using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoIndexer
{
    class Car
    {
        int year;
        string[] name = new string[4];
        public int Year

        {
            get
            {
                return year;

            }
            set
            {
                year = value;
            }
        }

         public string this[int x]
        {
            get
            {
                return this[x];

            }
            set
            {
                name[x] = value;

            }
        }

        public void display()
        {
         foreach(string var in name)
            {
                Console.WriteLine(var);
            }
        }

    }
}
