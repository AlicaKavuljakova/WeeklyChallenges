using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Reflection.Metadata.Ecma335;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
            bool contains = false;
            if(string.Equals(words,null) || words.Contains(null)) { return false; }
            if(ignoreCase==true)
            {
                word= word.ToLower();
                var list=words.Select(x => x.ToLower()).ToList();
               contains= list.Contains(word);
            }
            if(ignoreCase==false)
            {
                contains = words.Contains(word);
            }
          return contains;

        }

        public bool IsPrimeNumber(int num)
        {
            bool isPrime = false;
           if(num>=0)
            {
                if(num%2!=0 && num % 3 != 0)
                {
                    isPrime = true;
                }
                if(num==1)
                {
                    isPrime = false;
                }
                if(num==2 || num==3)
                {
                    isPrime = true;
                }
            }
           return isPrime;
        }
        
         
        




        public int IndexOfLastUniqueLetter(string str)
        {bool t= false;
            int order = -1;
            if (str.Length == 1) { return 0; }
        
          //  var single = str.ToList().GroupBy(n=>n).Where(n => n.Count() == 1).ToString();
            if (str == null || str.Length == 0) { order = -1; }
         for(int i=0; i < str.Length; i++)
            {
                t = true;
                for(int j=0; j<str.Length; j++)
                {
                    if (str[i] == str[j] && i!=j )
                    {
                        t = false;
                    }
                }

                if (t == true)
                {
                    order = i;
                }
            } return order;   
          
           
        }

        public int MaxConsecutiveCount(int[] numbers)
        { int counter = 0;
          for(int i=0; i<numbers.Length; i++)
            {
                int current = 1;
                for(int a=i+1;a<numbers.Length; a++)
                {
                    if (numbers[i] != numbers[a])
                    {
                        break;
                    }
                    current++;
                }
                if (current > counter) { counter=current; }
            }
          return counter;
        }

        public double[] GetEveryNthElement(List<double> elements, int n)
        {  
            var list= new List<double>();
          if(n<=0 || elements==null || elements.Count <= 0) { return new double[0]; }  
            for(int i=n-1;i<elements.Count;i+=n) 
            {
                list.Add(elements[i]);
            }
            return list.ToArray();  
        }
    }
}
