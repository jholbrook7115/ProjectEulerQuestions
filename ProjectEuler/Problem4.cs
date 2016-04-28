using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ProjectEuler
{
    public class Problem4
    {
        public int largest3DigitPalindromeBrute()
        {
            int result = 0;
            for (int i = 999; i > 900; i--)
            {
                for(int j = 999; j > 900; j--)
                {
                    int sum = i * j;
                    if (isPalindrome(sum) == true)
                    {
                        Debug.WriteLine(sum);
                        if (sum > result)
                        {
                            result = sum;
                        }
                    }
                }
            }

            return result;
        }
        public bool isPalindrome(int number)
        {
            int n = number;
            int rev = 0;
            int tmp = 0;
            while(number > 0)
            {
                tmp = number % 10;
                rev = rev * 10 + tmp;
                number /= 10;
            }
            if(n == rev)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
