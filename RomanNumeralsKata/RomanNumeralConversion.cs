using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            _numeralsList = new string[] { "I", "IV", "V", "IX", "X","XL" , "L", "XC", "C", "D", "M" };
            _numberEquivalents = new int[] { 1, 4, 5, 9, 10, 40,  50, 90,  100, 500, 1000 };

        }

        public int Convert(string romanNumeral)
        {
            RomanNumeral = romanNumeral;

            string tempNumeral = RomanNumeral;


            return 4;
        }

        public string Convert(int number)
        {
            int tempNumber = number;
            string numeral = "";

            if (number > 3550)
                return "Number Too Large";

            if (number == 0 || number < 0 )
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

            return numeral;
        }
    }
}
