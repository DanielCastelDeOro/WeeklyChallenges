using System;

using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Globalization;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            for (int i = 0; i < vals.Length; i++)
            {
                if (vals[i] == false)
                {
                    return true;
                }
            }
            return false;
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            if (numbers == null || numbers.Count() == 0)
            {
                return false;
            }
            var sum = numbers.Sum();
            return (sum % 2 != 0);
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
           throw new NotImplementedException();

            var isLower = false;
            var isUpper = false;
            var isNumber = false;

            for (int i = 0; i < password.Length; i++)
            {
                if (char.IsUpper(password[i]))
                {
                    isUpper = true;
                }
                if (char.IsLower(password[i]))
                {
                    isLower = true;
                }
                if (char.IsNumber(password[i]))
                {
                    isNumber = true;
                }
                if (isLower ==true && isUpper == true && isNumber == true)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public char GetFirstLetterOfString(string val)
        {
            return val.First();
            
        }

        public char GetLastLetterOfString(string val)
        {
            return val.Last();

        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            try
            {
                return dividend / divisor;

            }
            catch (System.DivideByZeroException e)
            {
                return divisor / dividend;
                throw;
            }
           




        }

        public int LastMinusFirst(int[] nums)
        {
            return nums.Last() - nums.First();
     
        }

        public int[] GetOddsBelow100()
        {
            //throw new NotImplementedException();
            var list = new List<int>();

            for (int i = 0; i < 100; i++)
            {
                if (i % 2 != 0)
                {
                    list.Add(i);
                }
            }
            return list.ToArray();
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            for (int i = 0; i < words.Length; i++)
            {
               words[i] = words[i].ToUpper();
            }
        }
    }
}
