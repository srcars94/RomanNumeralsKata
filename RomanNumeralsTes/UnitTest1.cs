using NUnit.Framework;
using RomanNumeralsKata;

namespace RomanNumeralsTes
{
    public class Tests
    {
        private readonly Program p;
        public Tests()
        {
            p = new Program();
        }

        [Test]
        public void One_Roman_Numerals([Values(1)] int amount)
        {
            var result = p.Convert(amount);

            Assert.AreEqual("I", result);
        }

        [Test]
        public void Two_Roman_Numerals([Values(2)] int amount)
        {
            var result = p.Convert(amount);

            Assert.AreEqual("II", result);
        }
    }
}