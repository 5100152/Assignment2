using System.Linq;
using System.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class Numbers
    {
        public static string ConvertNumtoWords(int num)
        {
            string[] units = { "", "One ", "Two ", "Three ", "Four ", "Five ", "Six ", "Seven ", "Eight ", "Nine ","Ten" };
            string[] doubleDigits = { "", "Eleven ", "Twelve ", "Thirteen ", "Fourteen ", "Fifteen ", "Sixteen ", "Seventeen ", "Eighteen ", "Nineteen " };
            string[] tens = { " ", " ", "Twenty ", "Thirty ", "Forty ", "Fifty ", "Sixty ", "Seventy ", "Eighty ", "Ninety " };
            string hundred = "hundred";
            string thousand = "thousand";

            Console.WriteLine("Enter a number from 0 to 9999");
            string number = Console.ReadLine();
            int convertedNumbers = Convert.ToInt32(number);
            string result = " ";

            int n;
            if (convertedNumbers == 0)
            {
                return "Zero";
            }
            else if (convertedNumbers <= 9)
            {
                return units[convertedNumbers];
            }
            else if (convertedNumbers <= 19)
            {
                return doubleDigits[convertedNumbers - 10];
            }
            else if (convertedNumbers <= 99)
            {
                return tens[(convertedNumbers / 10)] + units[(convertedNumbers % 10)];
            }
            else if (convertedNumbers <= 109)
            {
                return units[convertedNumbers / 100] + "Hundred and " + units[convertedNumbers % 10];
            }
            else if (convertedNumbers <= 110)
            {
                return units[convertedNumbers / 100] + "Hundred and " + tens[(convertedNumbers / 10 % 10)] + doubleDigits[convertedNumbers % 10];
            }
            else if (convertedNumbers <= 120)
            {
                return units[convertedNumbers / 100] + "Hundred and " + doubleDigits[(convertedNumbers / 10 % 10)];
            }
            else if (convertedNumbers <= 1109)
            {
                return units[convertedNumbers / 1000] + " Thousand " + units[convertedNumbers / 100 % 10] + "Hundred" + tens[convertedNumbers % 100 / 10] + " " + units[convertedNumbers % 10];

            }
          
            else if (convertedNumbers <= 1120)
            {
                return units[convertedNumbers / 1000] + " Thousand " + units[convertedNumbers / 100 % 10] + "Hundred" + " " + doubleDigits[convertedNumbers % 10];
            }






            else if (convertedNumbers <= 1209)
            {
                return units[convertedNumbers / 1000] + " Thousand " + units[convertedNumbers / 100 % 10] + "Hundred" + tens[convertedNumbers % 100 / 10] + " " + units[convertedNumbers % 10];

            }

            else if (convertedNumbers <= 1220)
            {
                return units[convertedNumbers / 1000] + " Thousand " + units[convertedNumbers / 100 % 10] + "Hundred" + " " + doubleDigits[convertedNumbers % 10];
            }



            else if (convertedNumbers <= 1309)
            {
                return units[convertedNumbers / 1000] + " Thousand " + units[convertedNumbers / 100 % 10] + "Hundred" + tens[convertedNumbers % 100 / 10] + " " + units[convertedNumbers % 10];

            }

            else if (convertedNumbers <= 1320)
            {
                return units[convertedNumbers / 1000] + " Thousand " + units[convertedNumbers / 100 % 10] + "Hundred" + " " + doubleDigits[convertedNumbers % 10];
            }



            else if (convertedNumbers <= 1409)
            {
                return units[convertedNumbers / 1000] + " Thousand " + units[convertedNumbers / 100 % 10] + "Hundred" + tens[convertedNumbers % 100 / 10] + " " + units[convertedNumbers % 10];

            }

            else if (convertedNumbers <= 1420)
            {
                return units[convertedNumbers / 1000] + " Thousand " + units[convertedNumbers / 100 % 10] + "Hundred" + " " + doubleDigits[convertedNumbers % 10];
            }



            else if (convertedNumbers <= 1509)
            {
                return units[convertedNumbers / 1000] + " Thousand " + units[convertedNumbers / 100 % 10] + "Hundred" + tens[convertedNumbers % 100 / 10] + " " + units[convertedNumbers % 10];

            }

            else if (convertedNumbers <= 1520)
            {
                return units[convertedNumbers / 1000] + " Thousand " + units[convertedNumbers / 100 % 10] + "Hundred" + " " + doubleDigits[convertedNumbers % 10];
            }

            else if (convertedNumbers <= 1609)
            {
                return units[convertedNumbers / 1000] + " Thousand " + units[convertedNumbers / 100 % 10] + "Hundred" + tens[convertedNumbers % 100 / 10] + " " + units[convertedNumbers % 10];

            }

            else if (convertedNumbers <= 1620)
            {
                return units[convertedNumbers / 1000] + " Thousand " + units[convertedNumbers / 100 % 10] + "Hundred" + " " + doubleDigits[convertedNumbers % 10];
            }



            else if (convertedNumbers <= 1709)
            {
                return units[convertedNumbers / 1000] + " Thousand " + units[convertedNumbers / 100 % 10] + "Hundred" + tens[convertedNumbers % 100 / 10] + " " + units[convertedNumbers % 10];

            }

            else if (convertedNumbers <= 1720)
            {
                return units[convertedNumbers / 1000] + " Thousand " + units[convertedNumbers / 100 % 10] + "Hundred" + " " + doubleDigits[convertedNumbers % 10];
            }


            else if (convertedNumbers <= 1809)
            {
                return units[convertedNumbers / 1000] + " Thousand " + units[convertedNumbers / 100 % 10] + "Hundred" + tens[convertedNumbers % 100 / 10] + " " + units[convertedNumbers % 10];

            }

            else if (convertedNumbers <= 1820)
            {
                return units[convertedNumbers / 1000] + " Thousand " + units[convertedNumbers / 100 % 10] + "Hundred" + " " + doubleDigits[convertedNumbers % 10];
            }


            else if (convertedNumbers <= 1909)
            {
                return units[convertedNumbers / 1000] + " Thousand " + units[convertedNumbers / 100 % 10] + "Hundred" + tens[convertedNumbers % 100 / 10] + " " + units[convertedNumbers % 10];

            }

            else if (convertedNumbers <= 1920)
            {
                return units[convertedNumbers / 1000] + " Thousand " + units[convertedNumbers / 100 % 10] + "Hundred" + " " + doubleDigits[convertedNumbers % 10];
            }






            else if (convertedNumbers <= 9999)
            {

                return units[convertedNumbers / 1000] + " Thousand " + units[convertedNumbers / 100 % 10] + "Hundred" + tens[convertedNumbers % 100 / 10] + " " + units[convertedNumbers % 10];

            }
            return "";
        }
    }
           
    }
