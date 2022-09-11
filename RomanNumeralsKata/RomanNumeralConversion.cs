using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace RomanNumeralsKata
{
    public class RomanNumeralConversion
    {
        public string RomanNumeral { get; set; }
        public int Number { get; set; }
        public RomanNumeralConversion() : this("I", 1) { }

        private string[] _numeralsList;
        private int[] _numberEquivalents;
        public RomanNumeralConversion(string romanNumeral, int number)
        {
            RomanNumeral = romanNumeral;
            Number = number;

            _numeralsList = new string[] { "I", "IV", "V", "IX", "X", "XL", "L", "XC", "C", "CD", "D", "CM", "M" };
            _numberEquivalents = new int[] { 1, 4, 5, 9, 10, 40, 50, 90, 100, 400, 500, 900, 1000 };

        }

        public bool CheckValidity(string numeral)
        {
            // Checking whether user entered valid pattern of Roman Numeral
            const string PATTERN = @"^M{0,3}(CM|CD|D?C{0,3})(XC|XL|L?X{0,3})(IX|IV|V?I{0,3})$";
            Regex regex = new(PATTERN);
            Match match = regex.Match(new string(numeral));

            return match.Success;
        }

        public int Convert(string romanNumeral)
        {
            //Converts a Roman Numeral to a number
            int sum = 0;
            int firstNumber = 0;
            int nextNumber = 0;

            RomanNumeral = romanNumeral;

            if (CheckValidity(romanNumeral) == false)
            {
                sum = -1;
                return sum;
            }

            int len = RomanNumeral.Length;
            for (int i = 0; i < len; i++)
            {
                firstNumber = _numberEquivalents[Array.IndexOf(_numeralsList, RomanNumeral[i].ToString())];
                if (len == 1)
                {
                    //if only one numeral character is entered by user
                    sum += firstNumber;
                    break;
                }

                if ((i + 1) < len)
                {
                    //if user entered multi character numeral
                    nextNumber = _numberEquivalents[Array.IndexOf(_numeralsList, RomanNumeral[i + 1].ToString())];
                    if (firstNumber < nextNumber)
                    {
                        sum += (nextNumber - firstNumber);
                        i++;
                    }
                    else
                    {
                        sum += firstNumber;
                    }
                }
                else
                {
                    if (i + 1 == len)
                    {
                        sum += firstNumber;
                        break;

                    }
                }

            }
            return sum;

        }


        public string Convert(int number)
        {
            //Converts a number to a Roman Numeral
            int tempNumber = number;
            string numeral = "";

            // Method should return error message when number is 0, negative or bigger than 3999
            if (number > 3999)
                return "Number Too Large";

            if (number == 0 || number < 0)
                return $"For Romans {number} did not exist.";

            while (tempNumber > 0)
            {
                int largestNumInList = (from num in _numberEquivalents
                                        where (num <= tempNumber)
                                        select num).Max();

                int indexOfNumber = Array.IndexOf(_numberEquivalents, largestNumInList);

                numeral += _numeralsList[indexOfNumber];

                tempNumber -= largestNumInList;
            }

            RomanNumeral = numeral;
            Number = number;
            if (CheckValidity(numeral) == false)
                return "Generated Invalid Numeral By Program";
            else
                return numeral;
        }
    }
}
