using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetLab01
{
    internal class Factorial
    {
        public void calculateFactorial()
        {
            int i = 0, 
            fact = 1;
            Console.WriteLine("Enter the number to find factorial: ");
            int input = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= input; i++)
            {
                fact = fact * i;
            }
            Console.WriteLine("The factorial of the  " + input + " is " + fact);
        }
    }
}
