using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ProjectEuler
{
    public class Problem3
    {

        public int largestPrimeFactorBrute(long LargeNumber)
        {
            List<int> primeNumbers = new List<int>();
            primeNumbers.Add(2);
            long number = LargeNumber;

            int highestFactor = 2;
            if(number == 2)
            {
                return highestFactor;
            }
            //double sqrtNum = Math.Sqrt(number);
            double n = number / 2;
            for(int i = 3; i <= Math.Floor(n); i = i+2)
            {
                bool isPrime = false;
                foreach(int num in primeNumbers)
                {
                    if(i%num == 0)
                    {
                        //Not a prime number
                        isPrime = false;
                        break;
                    }
                    else
                    {
                        //Is a prime number; add to list of prime numbers
                        isPrime = true;
                    }
                }
                if (isPrime == true)
                {
                    primeNumbers.Add(i);
                    if (number % i == 0)
                    {
                        //it is prime and it is a factor of the number given
                        highestFactor = i;
                    }
                    isPrime = false;
                }
                
            }
            return highestFactor;
        }
        public long largestPrimeFactorSmart(long largeNumber)
        {
            long highestFactor = 0;
            long tmpNumber = largeNumber;
            int i = 2;
            while(i * i <= tmpNumber)
            {
                if(tmpNumber%i == 0)
                {
                    tmpNumber /= i;
                    highestFactor = i;
                }
                else
                {
                    i = (i == 2) ? 3 : i + 2;
                }
            }
            if (tmpNumber > highestFactor)
            {
                highestFactor = tmpNumber;
            }
            return highestFactor;
        }
    }
}
