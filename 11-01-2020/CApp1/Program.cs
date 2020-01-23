using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            int id;
            string desig;
            int n;
            int k;

            Emploee e = new Emploee();
            List<Emploee> l = new List<Emploee>();
            do {
                Console.WriteLine("Menu:\n  1.Insert\n   2. display \n  3.update  \n 4.delete");

                Console.WriteLine("enter your option");
         
            int op = int.Parse(Console.ReadLine());
                switch (op)
                {

                    case 1:



                        do
                        {
                            Console.WriteLine("enter name");
                            name = Console.ReadLine();
                            Console.WriteLine("enter eid");
                            id = int.Parse(Console.ReadLine());
                            Console.WriteLine("enter desihnation");
                            desig = Console.ReadLine();
                            l.Add(new Emploee(name, id, desig));


                            Console.WriteLine("press 1 if you want to enter student details or else 0");
                            n = int.Parse(Console.ReadLine());

                        } while (n == 1);
                        break;

                    case 2:
                        Console.WriteLine("value ion list");
                        foreach (Emploee m in l)

                        {
                            Console.WriteLine(m.ToString());

                        }
                        break;
                    case 3:
                        Console.WriteLine("enter id of the employee you want to update");
                        int s = int.Parse(Console.ReadLine());
                       
                        Emploee pid = l.Find(x=> s.Equals(x.eid) );


                      
                            Console.WriteLine("enter name you want to update");
                           pid. ename = Console.ReadLine();
                            Console.WriteLine("enter designation");
                           pid.edesig  = Console.ReadLine();
                           
                          
                            Console.WriteLine("details updated");

                    
                        break;
                    case 4:
                        Console.WriteLine("enter id of the employee you want to delete");
                        int num= int.Parse(Console.ReadLine());

                        List<Emploee> lid = l.FindAll(x => num.Equals(x.eid));
                        foreach (Emploee h in lid)

                        {
                            Emploee t = null;
                            foreach (Emploee val in l)
                            {
                                if (val.eid.Equals(num))
                                {
                                    t = val;
                                }
                            }
                            l.Remove(t);
                        }
                        break;


                            default:break;
                }
                Console.WriteLine("if you wnat to choose another press1");
                k = int.Parse(Console.ReadLine());

            } while (k == 1);



            Console.ReadKey();



        }
    }
}
