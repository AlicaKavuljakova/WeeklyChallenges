using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
           return char.IsLetter(c);
        }
        public bool CharacterIsNotALetter(char c) 
        {
            return !char.IsLetter(c);
        }
        public bool CountOfElementsIsEven(string[] vals)
        {
           if(vals.Length%2==0)
            {  return true; }
           else { return false; }
           
        }

        public bool IsNumberEven(int number)
        {
            if (number % 2 == 0)
            {
                return true;
            } else { return false; }
        }

        public bool IsNumberOdd(int num)
        {
          return  (num%2!=0)? true :false;
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            if ( numbers == null || numbers.Any()==false)
            {
                return 0;
            }
           return numbers.Min() + numbers.Max(); 
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            if(str1.Length< str2.Length)
            {
                return str1.Length;
            }
            else
            {
                return str2.Length;
            }
        }

        public int Sum(int[] numbers)
        {
            int sum=0;
            if (numbers== null)
            {
                sum = 0;
            }
            else
            {
              for(int i=0; i<numbers.Length;i++)
                {
                    sum += numbers[i];
                }
            } return sum;
        }

        public int SumEvens(int[] numbers)
        {
            int sum = 0;
            if(numbers==null)
            {
                sum= 0;
            }
            else
            {
             for(int i=0;i< numbers.Length;i++)
                {
                    if (numbers[i]%2==0)
                    {
                        sum += numbers[i];
                    }
                }
            } return sum;
        }

        public bool IsSumOdd(List<int> numbers)
        { 
            if (numbers == null || numbers.Sum()%2==0) { return false; }
        else { return true; }
           
      
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            long count = 0;
            if (number<=0)
            {
                count= 0;
            }
            else {
              count=  number / 2;
            }return count;
        }
    }
}
