using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication11
{
    class Program
    {
        static void Main(string[] args)
        {
            person per = new person();
            per.calculate(2, 4);
            per.calculatesum(1, 2);
            someclass sc = new someclass();
            sc.getschool();
            sc.yourschool();
            
        }
    }
}
