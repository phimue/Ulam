using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ulam
{
    public class UlamCalculator
    {
        private List<(int, int)> values;

        public UlamCalculator()
        { 
            this.values = new List<(int, int)>();
        }

        public void RunUlam(int[] startValues)
        {            
            foreach (int i in startValues)
            {
                values.Add((i, i));
                Console.WriteLine($"u({i}):");
                Ulam(i);

                (int, int) max = values.Max();

                foreach (var value in values)
                {
                    Console.WriteLine($"{value.Item1}: {value.Item2}");
                }

                Console.WriteLine($"Das größte x ist {max.Item1} mit u(x) = {max.Item2}.\n\n\n");
                values = new List<(int, int)>();
            }
        }

        private int Ulam(int start)
        {
            int returnValue = 0;
            if (start == 1)
            {
                returnValue = 1;
                //Console.WriteLine(returnValue);
                values.Add((start, returnValue));
                return 1;
            }
            if (start % 2 == 0)
            {
                returnValue = start / 2;
                //Console.WriteLine(returnValue);
                values.Add((start, returnValue));
                return Ulam(returnValue);
            }
            returnValue = 3 * start + 1;
            //Console.WriteLine(returnValue);
            values.Add((start, returnValue));
            return Ulam(returnValue);
        }
    }
}
