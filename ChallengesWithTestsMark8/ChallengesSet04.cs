using System;
using System.Linq;
using System.Net.WebSockets;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            var evens = 0;
            var odds = 0;
            foreach(var x in numbers)
            {
                if (x % 2 == 0)
                {
                    evens += x;
                }
                else if (x % 2 != 0)
                {
                    odds += x;
                }
            }
            return evens - odds;
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            var one = str1.Length;
            var two = str2.Length;
            var three = str3.Length;
            var four = str4.Length;
            if(one < two && one < three && one < four)
            {
                return one;
            }
            else if(two <= one && two < three && two < four)
            {
                return two;
            }
            else if(three <= one && three <= two && three < four)
            {
                return three;
            }
            else { return four; }
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            var one = number1;
            var two = number2;
            var three = number3;
            var four = number4;
            if (one < two && one < three && one < four)
            {
                return one;
            }
            else if (two <= one && two < three && two < four)
            {
                return two;
            }
            else if (three <= one && three <= two && three < four)
            {
                return three;
            }
            else { return four; }
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            throw new NotImplementedException();
        }

        public bool IsStringANumber(string input)
        {
            int a = 0;
            if( input == null)
            {
                return false;
            }
            if(input.Length < 1)
            {
                return false;
            }
            
           foreach(var n in input)
            {
                if (char.IsDigit(n))
                {
                    a++;
                }
                else if (char.IsLetter(n))
                {
                    a += 0;
                }
                else if (char.IsSymbol(n))
                {
                    a += 0;
                }
                else if( n == '.')
                {
                    a++;
                }
                else if(n == '-')
                {
                    a++;
                }

            }
           if(a == input.Length)
            {
                return true;
            }
            else { return false; }
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            var count = 0;
            foreach(var o in objs)
            {
                if(o == null)
                {
                    count++;
                }
            }
            if (count > objs.Length / 2)
            {
                return true;
            }
            else { return false; }
        }

        public double AverageEvens(int[] numbers)
        {
            if(numbers == null)
            {
                return 0;
            }
            if(numbers.Length < 1)
            {
                return 0;
            }
           
            double sum = 0;
            int count = 0;
            foreach(var n in numbers)
            {
                if(n % 2 == 0)
                {
                    sum += n;
                    count++;
                }
                else if( n % 2 != 0)
                {
                    sum += 0;
                    count += 0;
                }
               
                
            }
            
                return sum / count;
           
        }

        public int Factorial(int number)
        {
            throw new NotImplementedException();
        }
    }
}
