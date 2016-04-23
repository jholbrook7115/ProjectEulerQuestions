using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    public class Problem1
    {
        static void Main(string[] args)
        {
            Problem1 prog = new Problem1();
            int sum = prog.sumOfMultiples(new int[] { 3, 5 }, 10);
            Console.WriteLine("The sum of all positives multiples of 3 and 5 below 1000:   " + sum);
            Console.ReadKey();
        }

        public int sumOfMultiples(int[] multiples, int upper)
        {
            int sum = 0;
            for(int i = 0; i < upper; i++)
            {
                foreach( int mult in multiples)
                {
                    if(i%mult == 0)
                    {
                        sum += i;
                        break;
                    }
                }
            }

            return sum;

        }
    }
}
