using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalPrograms
{
    public class Functional
    {
        public void Check_year()
        {
            //Check year is leap or not.
            Console.WriteLine("Enter the year wheather it is leap year or not");
            int year = Convert.ToInt32(Console.ReadLine());
            if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
            {
                Console.WriteLine("Year is a leap year");
            }
           else
            {
                Console.WriteLine("Year is not a leap year");
            }
        }
    }
}
