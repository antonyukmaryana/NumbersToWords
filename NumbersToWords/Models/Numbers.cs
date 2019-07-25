using System;
using System.Collections.Generic;

namespace NumbersToWords.Models
{
    public class Numbers
    {
        public static bool CheckZero(int number)
        {
            if (number == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static string output = "";

        public static string Convert(int number)
        {
            Dictionary<int, string> singleDigits = new Dictionary<int, string>() { 
                {1, "one"}, 
                {2, "two"}, 
                {3, "three"}, 
                {4, "four"}, 
                {5, "five"}, 
                {6, "six"}, 
                {7, "seven"}, 
                {8, "eight"}, 
                {9, "nine"} 
            };

            Dictionary<int, string> teens = new Dictionary<int, string>() {
                {11, "eleven"},
                {12, "twelve"}, 
                {13, "thirteen"},
                {14, "fourteen"}, 
                {15, "fifteen"}, 
                {16, "sixteen"}, 
                {17, "seventeen"}, 
                {18, "eighteen"}, 
                {19, "nineteen"} 
            };

            Dictionary<int, string> tens = new Dictionary<int, string>() {
                {1, "ten"},
                {2, "twenty"},
                {3, "thirty"}, 
                {4, "forty"},
                {5, "fifty"}, 
                {6, "sixty"}, 
                {7, "seventy"}, 
                {8, "eighty"}, 
                {9, "ninty"}
            };

            if (number < 10)
            {
                output += singleDigits[number];
            }
            else if (number < 20 && number != 10)
            {
                output += teens[number];
            }
            else if (number < 99)
            {
                int dividend = number / 10; // dividend = 3
                int remainder = number % 10;    // remainder = 3
                if (remainder == 0)
                {
                   output += tens[dividend];
                }
                else
                {
                    output += tens[dividend] + " " + singleDigits[remainder];
                }
            }
            else if  (number > 99 && number <1000)
            {
                int dividend = number / 100; //dividend = 3
                int remainder = number % 100; // remainder = 45
                if (remainder == 0)
                {
                    output += singleDigits[dividend]  + " hundred";
                }
                else  
                {
                    output += singleDigits[dividend] + " hundred ";
                    Convert(remainder);
                }
            }

            return output;

        }
    }
}