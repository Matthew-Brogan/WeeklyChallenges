using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {

            if (vals.Contains(false))
            {
                return true;
            } 
            else
            {
                return false;
            }
                
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
           
            if(numbers == null)
            {
                return false;
            }
            else if (numbers.Where(x => x % 2 != 0).Sum()%2!=0)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            var digiCount = 0;
            var lowCount = 0;
            var upCount = 0;


            foreach(var c in password)
            {
                
                if(char.IsDigit(c))
                {
                    digiCount++;
                }
                else if (char.IsLower(c))
                {
                    lowCount++;
                }
                else if (char.IsUpper(c))
                {
                    upCount++;
                }
            }
            if(digiCount >= 1 && lowCount >= 1 && upCount >= 1)
            {
                return true;
            }
            else { return false; }
                
         
            
            
        }

        public char GetFirstLetterOfString(string val)
        {
            return val[0];
        }

        public char GetLastLetterOfString(string val)
        {
            var x = val.Length;
            return val[x - 1];
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            if(dividend == 0 || divisor == 0)
            {
                return 0;
            }
            else { return dividend / divisor; }
        }

        public int LastMinusFirst(int[] nums)
        {
            var first = nums[0];
            var last = nums[nums.Length - 1];
            return last - first;
        }

        public int[] GetOddsBelow100()

        {
            int[] odds = Enumerable.Range(1, 100).Where(x => x % 2 != 0).ToArray();

            


            return odds;
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {

            for(int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].ToUpper();
              
            }
           


        }
    }
}
