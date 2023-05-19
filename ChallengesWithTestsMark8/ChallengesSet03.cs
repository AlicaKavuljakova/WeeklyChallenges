using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public  bool ArrayContainsAFalse(bool[] vals)
        {
            /* for(int i=0;i<vals.Length; i++)
             {
                 if (vals[i] == false)
                 {
                     return true;
                 }

             }return false;*/
            return (vals != null && vals.Length>0 && vals.Contains(false))?true:false;
          //return  (vals != null && vals.Length!=0 && vals.Contains(false)) ?true:false;
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            return (numbers != null && numbers.Where(x=>x%2!=0).Sum() % 2 != 0)? true:false;
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
           /* bool isUpper = password.Any(char.IsLower);
            bool isLower = password.Any(char.IsNumber);
            bool isNumber = password.Any(char.IsUpper);

            return (isUpper && isNumber && isLower) ? true : false;*/

           return password.Any(char.IsUpper)&& password.Any(char.IsLower) && password.Any(char.IsNumber);
            }

        public char GetFirstLetterOfString(string val)
        {
            return val[0];
        }

        public char GetLastLetterOfString(string val)
        {
            return val[val.Length-1];
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            return (divisor == 0) ? 0 : dividend / divisor;
        }

        public int LastMinusFirst(int[] nums)
        {
            return nums[nums.Length - 1] - nums[0];   
        }

        public int[] GetOddsBelow100()
        {
             List<int> odds = new List<int>();
              for (int i = 1; i < 100; i++)
              {
                  if (i % 2 != 0)
                  {
                      odds.Add(i);
                  }
              } return odds.ToArray();

        
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            for (int i=0;i<words.Length;i++)
            {
                words[i]= words[i].ToUpper();   
            }
            Console.WriteLine(words);
            
        }
    }
}
