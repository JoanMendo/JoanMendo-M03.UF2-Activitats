using System;

public class RomanNumeralConverter
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter a Roman numeral: ");
            string romanNumeral = Console.ReadLine();

            int value = ConvertToInteger(romanNumeral);
            Console.WriteLine("The value of the Roman numeral is: " + value);
        }
    }
    public static int ConvertToInteger(string romanNumeral)
    {
        int result = 0;
        int previousValue = 0;

        foreach (char c in romanNumeral)
        {
            int currentValue = GetValue(c);

            if (currentValue > previousValue)
            {
                result += currentValue - 2 * previousValue;
            }
            else
            {
                result += currentValue;
            }

            previousValue = currentValue;
        }

        return result;
    }

    public static int GetValue(char romanDigit)
    {
        switch (romanDigit)
        {
            case 'I':
                return 1;
            case 'V':
                return 5;
            case 'X':
                return 10;
            case 'L':
                return 50;
            case 'C':
                return 100;
            case 'D':
                return 500;
            case 'M':
                return 1000;
            default:
                throw new ArgumentException("Invalid Roman numeral digit: " + romanDigit);
        }
    }
}

