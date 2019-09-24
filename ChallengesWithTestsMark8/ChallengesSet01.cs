using System;
//DONE
namespace ChallengesWithTestsMark8
{
    public class ChallengesSet01
    {
        public bool AreTwoNumbersTheSame(int num1, int num2)
        {
            if (num1 == num2)
            {
                return true;
            }
            else
            {
                return false;      
            }
        }

        public double Subtract(double minuend, double subtrahend)
        {
            var subtract = minuend - subtrahend;

            return subtract;
        } 

        public int Add(int addend, int addend2)
        {
            var add = addend + addend2;

            return add;
        }

        public int GetSmallestNumber(int number1, int number2)
        {
            var getSmallestNumber = (number1 == number2);
                
            if (number1 > number2)
            {
                return number2;
            }
            else 
            {
                return number1; 
            }

        }

        public long Multiply(long factor1, long factor2)
        {
            var multiply = (factor1 * factor2);
            return multiply;
        }

        public string GetGreeting(string nameOfPerson)
        {
            return nameOfPerson == "" ?  "Hello!" : $"Hello, {nameOfPerson}!";  //"Hello, " + nameOfPerson + "!";

        }

        public string GetHey()
        {
            return "HEY!";
        }
    }
}
