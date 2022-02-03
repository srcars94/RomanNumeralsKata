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
        }

        static void Main(string[] args)
        {
        }

        public string Convert(int amount)
        {
            var i = 0;

            var romanString = string.Empty;

            while (i < amount)
            {
                var tempAmount = amount;

                if (tempAmount <= 4)
                {
                    romanString += romanNumeralsBank.Where(w => w.Key == 4).FirstOrDefault().Value;

                    tempAmount -= 4;

                    if (tempAmount == 0) break;
                }

                if (tempAmount <= 3)
                {
                    romanString += romanNumeralsBank.Where(w => w.Key == 1).FirstOrDefault().Value;

                    tempAmount -= 1;

                    if (tempAmount == 0) break;
                }


                i++;
            }

            return romanString;
        }
    }
}
