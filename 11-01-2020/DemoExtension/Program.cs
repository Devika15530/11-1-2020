using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoExtension
{
   static  class StringHelper//by using extension method we can extend the functionality
    {//helper class must be static
        public static  string FirstCaseChhange(this string name)//'this' should be used to refer parameter


        {
            char[] input = name.ToCharArray();
            input[0] = char.IsUpper(input[0]) ? char.ToLower(input[0]) : char.ToUpper(input[0]);
            return new string( input);
            //return input.ToString();
        }
    }
    class Program
    {
      
        static void Main(string[] args)
        {


           string name = "welcome";
            Console.WriteLine(name.FirstCaseChhange());
            var anonymoustype = new { property1 = "ajay", property2 = 12, property3 = true };
            Console.WriteLine(anonymoustype.GetType());

            Console.ReadKey();
        }
    }
}
