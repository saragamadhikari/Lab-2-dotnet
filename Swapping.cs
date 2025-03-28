using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetLab01
{
    internal class Swapping
    {
        public void swapping(int a , int b)
        {
            Console.WriteLine(" the numbers before swapping are " + a + ", " + b);
            int temp = 0;
            temp = a;
            a = b;
            b = temp;
            Console.WriteLine("the numbers after swapping are "+ a + ", " + b);
        }


    }
}
