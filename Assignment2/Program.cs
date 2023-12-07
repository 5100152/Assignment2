using System;

namespace Assignment2
{
    public static class HumanFriendlyInteger
    {
        static string[] ones = new string[] { "", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine" };
        static string[] teens = new string[] { "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen" };
        static string[] tens = new string[] { "", "Ten", "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };
        static string[] thousandsGroups = { "", " Thousand", " Million", " Billion" };

        private static string GenerateFriendlyInteger(int n, string leftDigits, int thousands)
        {
            if (n == 0)
            {
                return leftDigits;
            }

            string friendlyInt = leftDigits;

            if (friendlyInt.Length > 0)
            {
                friendlyInt += " ";
            }

            if (n < 10)
            {
                friendlyInt += ones[n];
            }
            else if (n < 20)
            {
                friendlyInt += teens[n - 10];
            }
            else if (n < 100)
            {
                friendlyInt += GenerateFriendlyInteger(n % 10, tens[n / 10], 0);
            }
            else if (n < 1000)
            {
                friendlyInt += GenerateFriendlyInteger(n % 100, (ones[n / 100] + " Hundred"), 0);
            }
            else
            {
                friendlyInt += GenerateFriendlyInteger(n % 1000, GenerateFriendlyInteger(n / 1000, "", thousands + 1), 0);
                if (n % 1000 == 0)
                {
                    return friendlyInt;
                }
            }

            return friendlyInt + thousandsGroups[thousands];
        }

        public static string IntegerToWritten(int n)
        {
            if (n == 0)
            {
                return "Zero";
            }
            else if (n < 0)
            {
                return "Negative " + IntegerToWritten(-n);
            }

            return GenerateFriendlyInteger(n, "", 0);
        }

        public static void Main(string[] args)
        {
            Console.Write("Enter a number (up to 9999): ");
            if (int.TryParse(Console.ReadLine(), out int userInput) && userInput >= 0 && userInput <= 9999)
            {
                string writtenForm = IntegerToWritten(userInput);
                Console.WriteLine($"Written form: {writtenForm}");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }
    }
}
