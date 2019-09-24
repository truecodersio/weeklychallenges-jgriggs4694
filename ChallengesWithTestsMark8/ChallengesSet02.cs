﻿using System;
using System.Collections.Generic;
using System.Linq;
//DONE
namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            return Char.IsLetter(c);
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            if (vals.Length % 2 == 0)
            {
                return true;
            }
            else
            {
                return false; 
            }
        }

        public bool IsNumberEven(int number)
        {
            if (number % 2 == 0)
            {
                
                return true;

            }
            else
            {
                return false;
            }
        }

        public bool IsNumberOdd(int num)
        {
            if (num % 2 == 0)
            {
                return false;

            }
            else
            {
                return true;
            }
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            if (numbers == null || numbers.Count() == 0)
            {
                return 0;
            }
            return numbers.Min() + numbers.Max();
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            if (str1.Length > str2.Length)
            {
                return str2.Length;
            }
            else 
            {
                return str1.Length;
            }
        }

        public int Sum(int[] numbers)
        {
            int i;
            var sum = 0;
            if ( numbers == null)
            {
                return 0;
            }
            for (i = 0; i < numbers.Length; i++)
            {
                sum = numbers[i] + sum;
                
            }
            return sum;
            
        }

        public int SumEvens(int[] numbers)
        {
            int i;
            var sum = 0;
            if (numbers == null || numbers.Count() == 0)
            {
                return 0;
            }
            for (i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                sum = numbers[i] + sum;
            }
            return sum;
        }

        public bool IsSumOdd(List<int> numbers)
        {
            int result = 0;
            if (numbers == null)
            {
                return false;
            }
            for (int i = 0; i < numbers.Count; i++)
            {
                result += numbers[i];
            }
            if ( result % 2 != 0)
            {
                return true;
            }
            else
            { 
                return false;
            }
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            long count = 0;
            for (long i = number -1; i > 0; i--)
            {
                if (i % 2 != 0)
                {
                    count++;
                }
            }
            return count; 
        }
    }
}
