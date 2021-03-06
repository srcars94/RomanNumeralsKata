using System;
using System.Collections.Generic;
using System.Linq;

namespace RomanNumeralsKata
{
    public class Program
    {

        private Dictionary<int, string> romanNumeralsBank = new Dictionary<int, string>();

        public Program()
        {
            romanNumeralsBank.Add(1, "I");
            romanNumeralsBank.Add(4, "IV");
            romanNumeralsBank.Add(5, "V");
            romanNumeralsBank.Add(9, "IX");
            romanNumeralsBank.Add(10, "X");
        }

        static void Main(string[] args)
        {
        }

        public string Convert(int amount)
        {
            var romanString = string.Empty;

            var tempAmount = amount;

            for (var i = 0; i < amount; i++)
            {
                if (tempAmount >= 10)
                {
                    romanString += romanNumeralsBank.Where(w => w.Key == 10).FirstOrDefault().Value;

                    tempAmount -= 10;

                    continue;
                }

                if (tempAmount >= 9)
                {
                    romanString += romanNumeralsBank.Where(w => w.Key == 9).FirstOrDefault().Value;

                    tempAmount -= 9;
                    continue;
                }

                if (tempAmount >= 5)
                {
                    romanString += romanNumeralsBank.Where(w => w.Key == 5).FirstOrDefault().Value;

                    tempAmount -= 5;
                    continue;
                }

                if (tempAmount >= 4)
                {
                    romanString += romanNumeralsBank.Where(w => w.Key == 4).FirstOrDefault().Value;

                    tempAmount -= 4;
                    continue;
                }

                if (tempAmount >= 1)
                {
                    romanString += romanNumeralsBank.Where(w => w.Key == 1).FirstOrDefault().Value;

                    tempAmount -= 1;
                    continue;
                }

                if (tempAmount == 0) break;
            }
            return romanString;
        }
    }
}
