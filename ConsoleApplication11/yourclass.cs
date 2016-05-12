using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication11
{
    public partial class person : Iaccount
    {
        public person(int c)
        {
            product = product+c;
        }
        public int calculatesum(int a, int b)
        {
            StringBuilder sb = new StringBuilder();
            int sum = a+b;
           sum= calculate(sum, 3);
            return sum;
        }

        public virtual void getschool()
        {
            Console.WriteLine("My school");
        }

        partial void myname();

        
    }

    
}
