using NUnit.Framework;
using RomanNumeralsKata;

namespace RomanNumeralsTes
{
    public class Tests
    {
        [Test]
        public void Does_Return_String([Values(1)] int amount)
        {
            var p = new Program();

            var result = p.Convert(amount);

            Assert.AreEqual("1", result);
        }
    }
}