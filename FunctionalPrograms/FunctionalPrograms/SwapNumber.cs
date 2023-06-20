using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalPrograms
{
    public class SwapNumber
    {
        public void swapNumbers() 
        {
            //Swapping of the Two Numbers
            Console.WriteLine("Enter the first Number");
            int a=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Second Number");
            int b=Convert.ToInt32(Console.ReadLine());
            a=a+b;
            b=a-b;
            a=a-b;
            Console.WriteLine(" First Number After Swapping :"+a);
            Console.WriteLine("Second Number After Swapping:"+b);
        }
    }
}
