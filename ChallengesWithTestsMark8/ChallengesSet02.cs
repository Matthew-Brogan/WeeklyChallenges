using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            string alphabits = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            if (alphabits.Contains(c))
            {
                return true;
            }
            else { return false; }
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            if(vals.Length % 2 == 0)
            {
                return true;
            }
            else { return false; }
        }

        public bool IsNumberEven(int number)
        {
            if (number % 2 == 0)
            {
                return true;
            }
            else { return false; }
        }

        public bool IsNumberOdd(int num)
        {
           if ( num % 2 != 0 )
            {
                return true; 
            }
            else 
            { 
                return false;
            }
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            if(numbers == null )
            {
                return 0;
            }
            if(numbers.Count() <= 0)
            {
                return 0;
            }
            double db1 = numbers.Min();
            double db2 = numbers.Max();
            var sum = db1 + db2;
          
         return sum;
                
            
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
           var answer = (str1.Length > str2.Length) ? str2.Length : str1.Length;
            return answer;
        }

        public int Sum(int[] numbers)
        {
            if(numbers == null)
            {
                return 0;
            }
            else
            {
                return numbers.Sum();
            }
            
        }

        public int SumEvens(int[] numbers)
        {
            if(numbers == null)
            {
                return 0;
            }
            else
            {
              int num = 0;
              foreach(int x in numbers)
                {
                     if(x % 2 == 0)
                     {
                         num += x;
                    
                     }
               
                
              }return num;
            }
                    
          
        }

        public bool IsSumOdd(List<int> numbers)
        {
            if(numbers == null)
            {
                return false;
            }
            int sum = 0;
            foreach(int num in numbers)
            {
                sum += num;
            }
            if (sum % 2 == 0)
            {
                return false;
            }
            else return true;
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        { 
            if(number > 0)
            {
                return number / 2;
            }
            else
            {
                return 0;
            }
            
        }
    }
}
