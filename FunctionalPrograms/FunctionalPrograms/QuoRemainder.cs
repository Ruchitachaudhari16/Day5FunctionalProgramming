using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalPrograms
{
    public class QuoRemainder
    {
        public  void CheckQuoRemain()
        {
            //Compute Remainder and Quotient
            Console.WriteLine("Enter the Dividend");
            int dividend = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Divisor");
            int divisor = Convert.ToInt32(Console.ReadLine());
            //Quotient
            int quotient = dividend / divisor;
            Console.WriteLine("quotient is:" + quotient);
            //Remainder
            int remainder = dividend % divisor;
            Console.WriteLine("Remainder is:" + remainder);
        }
    }
}
