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
            romanNumeralsBank.Add(5, "V");
            romanNumeralsBank.Add(10, "X");
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
                if (i <= 3)
                {
                    var x = romanNumeralsBank.Where(w => w.Key == 1).FirstOrDefault().Value;

                    romanString += x;
                }
            }

            return romanString;
        }
    }
}
