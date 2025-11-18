using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop4
{
    internal class Calculator
    {
        // Void method
        public void PrintWelcome()
        {
            Console.WriteLine("Welcome to the Calculator!");
        }

        // Method that returns addition
        public int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        // Multiply method with optional parameter
        public int Multiply(int num1, int num2 = 1)
        {
            return num1 * num2;
        }
    }
}
