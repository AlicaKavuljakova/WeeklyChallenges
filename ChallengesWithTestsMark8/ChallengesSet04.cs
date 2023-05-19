using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            return numbers.Where(x => x % 2 == 0).Sum() - numbers.Where(x => x % 2 != 0).Sum();
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            List<int> numbers = new List<int>() { str1.Length, str2.Length, str3.Length, str4.Length };
            numbers.Sort();
           // return numbers[0];
return numbers.Min();


        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            IEnumerable<int> numbers = new List<int>() { number1, number2, number3, number4 };
            return numbers.OrderBy(x => x).ToList()[0];
            //or return numbers.Min();


        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {

            biz.Name = "TrueCoders";
            Console.WriteLine(biz.Name);
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            IEnumerable<int> ints = new List<int>() { sideLength1, sideLength2, sideLength3 };
            var ordered = ints.OrderBy(x => x).ToList();
            return (ordered[0] + ordered[1] > ordered[2]) ? true : false;

        }

        public bool IsStringANumber(string input)
        {
       return  double.TryParse(input, out double result);
             
           
        }
        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
          var nulls=  objs.Where(x => x is null ).ToList().Count();
            var others= objs.Where(x => x != null).ToList().Count();
           return  (nulls > others) ? true : false;
        }

        public double AverageEvens(int[] numbers)
        {
          

           return  (numbers == null || numbers.Length == 0 || numbers.Where(x => x % 2 == 0).Count() == 0) ? 0 : numbers.Where(x => x % 2 == 0).ToArray().Average();
        }

        public int Factorial(int number)
        {
           
            int facto=0;
            if (number < 0 )
            {
                throw new ArgumentOutOfRangeException();
            }
            if(number == 0 || number ==1 )
            {
                facto = 1;
            }
           else
            {
                facto = Enumerable.Range(1, number).Aggregate(1, (p, item) => p * item); ;
            }
           
             
           
           return facto;

        }
    }
}
