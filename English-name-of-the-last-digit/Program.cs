
using System.Net.WebSockets;

namespace English_name_of_the_last_digit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            string numberEnglishName = GetEnglishName(number);
            Console.WriteLine($"English name for the last digit: {numberEnglishName}");
        }

        private static string GetEnglishName(int number)
        {
            // in case the number is negative
            number = Math.Abs(number);

            //extracting the last digit
            int lastDigit = number % 10;

            switch(lastDigit)
            {
                case 0:
                    return "zero";
                    
                case 1:
                    return "one";
                    
                case 2:
                    return "two";
                case 3:
                    return "three";
                case 4:
                    return "four";
                case 5:
                    return "five";
                case 6:
                    return "six";
                case 7:
                    return "seven";
                case 8:
                    return "eight";
                case 9:
                    return "nine";
                default:
                    return "Invalid input";
            }
        }
    }
}
