using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetLab01
{
    internal class EvenOdd
    {
        public void evenodd (int value)
        {
            if(value % 2 == 0)
            {
                Console.WriteLine("The value is even: " + value);

            }
            else
            {
                Console.WriteLine("The  value is odd: " +value); 
            }
        }

    }
}
