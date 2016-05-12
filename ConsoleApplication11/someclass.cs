using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication11
{
   public class someclass:person
    {
        public override void getschool()
        {
            base.getschool();
            Console.WriteLine("Derived my School");
        }

        public override void yourschool()
        {
            base.yourschool();
            Console.WriteLine("Derived your School");
        }

        public new void balance()
        {
            Console.WriteLine("Balance in their account is " + product + "");
        }
    }
}
