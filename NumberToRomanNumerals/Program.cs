using System;

namespace NumberToRomanNumerals
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number to conver to a Roman numeral: ");
            int num = int.Parse(Console.ReadLine());

            if (num >= 5000)
            {
                Console.WriteLine("Sorry! Standard Roman numerals do not go higher than 4,999.");
            }
            else
            {
                string[] thou = { "", "M", "MM", "MMM" };
                string[] hun = { "", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM" };
                string[] ten = { "", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC" };
                string[] ones = { "", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" };
                string roman = "";
                roman += thou[(int)(num / 1000) % 10];
                roman += hun[(int)(num / 100) % 10];
                roman += ten[(int)(num / 10) % 10];
                roman += ones[num % 10];

                Console.WriteLine(roman);
            }
        }
    }
}
