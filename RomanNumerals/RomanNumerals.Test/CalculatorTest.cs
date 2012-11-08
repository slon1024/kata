using NUnit.Framework;
using RomanNumerals.Engine;

namespace RomanNumerals.Test
{
    [TestFixture]
    public class CalculatorTest
    {
        private Calculator _calculator = null;

        [SetUp]
        public void SetUp()
        {
            _calculator = new Calculator(new SimpleEngine());
        }

        [TearDown]
        public void TearDown()
        {
            _calculator = null;
        }

        [Test]
        #region TestCase
        [TestCase("I", "I", "II")]
        [TestCase("I", "II", "III")]
        [TestCase("II", "II", "IV")]
        [TestCase("II", "III", "V")]
        [TestCase("III", "III", "VI")]
        [TestCase("III", "IV", "VII")]
        [TestCase("III", "V", "VIII")]
        [TestCase("III", "VI", "IX")]
        [TestCase("III", "VII", "X")]
        [TestCase("VII", "VII", "XIV")]
        [TestCase("IX", "IX", "XVIII")]
        [TestCase("X", "X", "XX")]
        [TestCase("X", "XX", "XXX")]
        [TestCase("XX", "XX", "XL")]
        [TestCase("XX", "XXX", "L")]
        [TestCase("XXX", "XXX", "LX")]
        [TestCase("XL", "XXX", "LXX")]
        [TestCase("XL", "XL", "LXXX")]
        [TestCase("XL", "L", "XC")]
        [TestCase("L", "L", "C")]
        [TestCase("C", "C", "CC")]
        [TestCase("CC", "C", "CCC")]
        [TestCase("CC", "CC", "CD")]
        [TestCase("CCC", "CC", "D")]
        [TestCase("CCC", "CCC", "DC")]
        [TestCase("CD", "CCC", "DCC")]
        [TestCase("CD", "CD", "DCCC")]
        [TestCase("D", "CD", "CM")]
        [TestCase("D", "D", "M")]
        [TestCase("M", "M", "MM")]
        [TestCase("M", "MM", "MMM")]
        [TestCase("DCCCLXXXVIII", "DCCCLXXXI", "MDCCLXIX")]
        #endregion
        public void AdditionTest(string first, string second, string expected)
        {
            var actual = _calculator.Add(first, second);
            
            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}