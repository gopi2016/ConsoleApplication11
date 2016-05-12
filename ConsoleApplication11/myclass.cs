using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication11
{
  public partial  class person
    {
       public int product;
        public person()
        {
            product = 0;
        }
        public int calculate(int a,int b)
        {
             product = a * b;
            return product;
        }
        public void balance()
        {
            Console.WriteLine("Balance in account is " + product + "");
        }

       public virtual void yourschool()
        {
            Console.WriteLine("Your school");
        }

        
    }
}
