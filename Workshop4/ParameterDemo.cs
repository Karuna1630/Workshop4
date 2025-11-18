using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop4
{
    internal class ParameterDemo
    {
        // Method using ref parameter
        public void Increase(ref int number)
        {
            // increase value by 10
            number += 10; 
        }

        // Method using out parameter
        public void GetFullName(out string fullname)
        {
            // assign full name
            fullname = "Karuna Giri"; 
        }

        // Method using params
        public int SumAll(params int[] numbers)
        {
            int sum = 0;
            foreach (int n in numbers)
            {
                sum += n;
            }
            return sum;
        }
    }
}
