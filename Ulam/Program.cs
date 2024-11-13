using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ulam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] startValues = new int[] { 15, 31, 409599, 409600 };
            
            var ulamCalculator = new UlamCalculator();
            ulamCalculator.RunUlam(startValues);

            Console.Read();
        }

        
    }
}
