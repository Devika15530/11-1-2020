using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoPattern
{
   public class Singleton
    {
        static int  count=0;
     static Singleton instance;//memory not allocated so object does not exist
        public static  Singleton GetInstance//obj of singleton 
        {
            get
            {
                if (instance == null) return new Singleton();//only for firdt object
                else
                    return instance;//existing instance ref returned 
            }
        }

   private Singleton()//constructor private
        {

            count++;
            Console.WriteLine(count);


        }
        public  void printDetails(String s)
        {
            Console.WriteLine(s);
        }
    }
}
