// See https://aka.ms/new-console-template for more information
using RomanNumeralsKata;


RomanNumeralConversion obj = new RomanNumeralConversion();

for(int i = 21; i <= 100; i++)
{ 
int num = i;
string numeral = obj.Convert(num);
Console.WriteLine(num + " in roman numeral is : " + numeral);
}