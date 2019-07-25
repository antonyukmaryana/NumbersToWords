using System;
using System.Collections.Generic;

namespace NumbersToWords.Models
{
    public class Numbers
    {
        public static Dictionary<int, string> singleDigits = new Dictionary<int, string>() { 
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

        public static Dictionary<int, string> teens = new Dictionary<int, string>() {
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

        public static Dictionary<int, string> tens = new Dictionary<int, string>() {
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
        
        public static int input;

        public static string output = "";

        public static void Convert100AndUp(int inputNum, int num, string numWord)
        {
            int dividend = inputNum / num;  // dividend = 20000 / 1000 = 20
            int remainder = inputNum % num; // remainder = 0
            if (dividend > 9)
            {
                Convert(dividend); // "twenty"
                Console.WriteLine("initial output: " + output);
                Console.WriteLine("dividend: " + dividend);
                Console.WriteLine("first output: " + output);
                Convert(input - inputNum); 
            }
            else
            {
                if (remainder == 0)
                {
                    output += singleDigits[dividend]  + " " + numWord;
                }
                else  
                {
                    output += singleDigits[dividend] + " " + numWord + " ";
                    Convert(remainder);
                }
            }
            
        }

        public static string Convert(int number)
        {
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
                Convert100AndUp(number, 100, "hundred");
            }
            else if (number > 999 && number <1000000)
            {
                Convert100AndUp(number, 1000, "thousand");
            }
            else if (number > 999999 && number <1000000000)
            {
                Convert100AndUp(number, 1000000, "million");
            }

            
            return output;
        }
    }
}