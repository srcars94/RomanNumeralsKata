using System;
using System.Collections.Generic;

namespace RomanNumeralsKata
{
    public class Program
    {

        private Dictionary<int, string> romanNumeralsBank = new Dictionary<int, string>();

        public Program()
        {
            romanNumeralsBank.Add(1, "I");
        }

        static void Main(string[] args)
        {
        }

        public string Convert(int amount)
        {
            foreach (var rn in romanNumeralsBank)
            {
                if (amount == rn.Key) return rn.Value;

                if (amount != rn.Key) continue;
            }

            return amount.ToString();
        }
    }
}
