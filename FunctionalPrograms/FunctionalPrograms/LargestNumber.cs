using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalPrograms
{
    public class LargestNumber
    {
        public void checkLargestNumber()
        {
            //Check the Largest Number among three Numbers.
            Console.WriteLine("Enter the First Number:");
            int numberOne=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Second Number");
            int numberTwo=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Third Number");
            int numberThree=Convert.ToInt32(Console.ReadLine());
            if (numberOne > numberTwo)
            {
                Console.WriteLine("First Number is Large");
            }
            else if (numberTwo > numberThree)
            {
                Console.WriteLine("Second Number is Large");
            }
            else 
            {
                Console.WriteLine("Third Number is Large");
            }

            }
        }
    }

