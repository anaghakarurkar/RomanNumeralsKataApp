// See https://aka.ms/new-console-template for more information
using RomanNumeralsKata;


RomanNumeralConversion obj = new RomanNumeralConversion();

for (int i = 1; i <= 100; i++)
{
    int num = i;
    string numeral = obj.Convert(num);

    Console.WriteLine(num + " in roman numeral is : " + numeral);
}

//checking roman numeral to number conversion

int convertedNumber = obj.Convert("XL");

System.Console.WriteLine(convertedNumber);