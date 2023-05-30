using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection.Metadata.Ecma335;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
            /*   int next = 0;
               int extra=1 ;
              // if(startNumber%n == 0) { next = startNumber + n; }
               if(startNumber == 0) { next = n; }
             while((startNumber + extra) % n != 0)
               {
                   extra++;
               }
             return next=startNumber+extra;
            */
            return (startNumber / n + 1) * n;
        }

        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {
            /*for(int i = 0; i < businesses.Length; i++)
               {
                  if( businesses[i].TotalRevenue==0)
                   {
                       businesses[i].Name = "CLOSED";
                   }
                   Console.WriteLine(businesses[i].Name);
               }
            */
            foreach (Business bus in businesses)
            {
                if (bus.TotalRevenue == 0)
                {
                    bus.Name = "CLOSED";
                }
                Console.WriteLine(bus.Name);
            }

        }

        public bool IsAscendingOrder(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0) { return false; }
  return   numbers.SequenceEqual(numbers.OrderBy(x=>x));


        }

        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0) { return 0; }
            int sum = 0;
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i - 1] % 2 == 0)
                {
                    sum += numbers[i];
                }
            }
            return sum;
        }

        public string TurnWordsIntoSentence(string[] words)
        {
            if (words == null || words.Length == 0) { return ""; }
            string sentence = "";
           foreach(string word in words)
            {
                if(word.Trim().Length >0)
                {
                    sentence += word.Trim() + " ";
                }
            }
            if (sentence.Length== 0) { return ""; }
            return sentence.Trim() + ".";
        }

        public double[] GetEveryFourthElement(List<double> elements)
        {
            var list = new List<double>();

        if(elements == null  || elements.Count == 0 ) { return new double[0]; }
                     for (int i =3; i < elements.Count; i += 4) { 
                list.Add(elements[i]);
            }
            return list.ToArray();
        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            int sum = 0;
            if (nums == null || nums.Length <= 1) { return false; }
            for(int i=0; i < nums.Length; i++)
            {
 for(int z=i+1; z<nums.Length; z++)  
                {
                    sum = nums[i] + nums[z];
                   if (sum==targetNumber)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
