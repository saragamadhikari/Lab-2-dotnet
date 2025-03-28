using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetLab01
{
    internal class Sumofnaturalno
    {
        public void sum(int n)
        {
            int sum = 0;
            for (int i = 0; i <= n; i++)
            {
                Console.WriteLine("The i is:  " +i);
                sum = sum + i;
                Console.WriteLine("The sum of n natural number is :" + sum);
            }
        }
    }
}
