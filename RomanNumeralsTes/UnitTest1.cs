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

        [Test]
        public void Four_Roman_Numerals([Values(4)] int amount)
        {
            var result = p.Convert(amount);

            Assert.AreEqual("IV", result);
        }


        [Test]
        public void Seven_Roman_Numerals([Values(7)] int amount)
        {
            var result = p.Convert(amount);

            Assert.AreEqual("VII", result);
        }

        [Test]
        public void Nine_Roman_Numerals([Values(9)] int amount)
        {
            var result = p.Convert(amount);

            Assert.AreEqual("IX", result);
        }

        [Test]
        public void Twenty_Roman_Numerals([Values(20)] int amount)
        {
            var result = p.Convert(amount);

            Assert.AreEqual("XX", result);
        }
    }
}