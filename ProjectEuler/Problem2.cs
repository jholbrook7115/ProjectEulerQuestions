using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    public class Problem2
    {
        //this method finds the sum of all even fibonacci numbers less than 4 million
        int sum = 0;
        int a = 2;
        int b = 1;
        public int sumOfEvenFibonacci(int limit)
        {
            int fibNum;
            if(limit < 2)
            {
                return 0;
            }
            else if(limit == 2)
            {
                return 2;
            }
            else
            {
                sum += 2;
                fibNum = a + b;
                while (a < limit)
                {

                    if(fibNum%2 == 0)
                    {
                        sum += fibNum;
                    }

                    b = a;
                    a = fibNum;
                    fibNum = a + b;
                }
                return sum;
            }
        }

    }
}
