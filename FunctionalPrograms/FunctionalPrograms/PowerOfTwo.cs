using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalPrograms
{
   public class PowerOfTwo
    {
        public void powerOfTwotable()
       
            {
            //Power of two
            //Print the table till that Number

                int i, number;
                Console.WriteLine("Enter the number to print the table");
                number = Convert.ToInt32(Console.ReadLine());
                for (i = 1; i <= number; i++)
                {
                    //number = number * i;
                    Console.WriteLine(number * i);
                }
                Console.ReadLine();
            }
        }
    }

