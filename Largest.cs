using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetLab01
{
    internal class Largest
    {
        public void largest(int a , int b, int c )
        {
            if(a>=b && a >= c)
            {
                Console.WriteLine(" The largest is: " + a);

            }
            else if(b>=a && b>= c)
            {
                Console.WriteLine(" The largest is: " + b);
            }
            else
            {
                Console.WriteLine("The largest is: " + c);
            }
        }

    }
}
