using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CApp1
{
    class Emploee
    {
     public    int eid;
       public string ename;
     public   string edesig;

       
       public  Emploee()
        {

        }

        public Emploee(string name, int tid, string desig)
        {
            this.eid = tid;
            this.ename = name;
            this.edesig= desig;


        }


       
        public override string ToString()
        {
            return this.eid + "\n" + this.ename + " " + this.edesig;
        }

        public override bool Equals(object obj)
        {
            Emploee temp = (Emploee)obj;
            if (this.eid == temp.eid )

                return true;
            else
                return false;

        }


    }
}
    