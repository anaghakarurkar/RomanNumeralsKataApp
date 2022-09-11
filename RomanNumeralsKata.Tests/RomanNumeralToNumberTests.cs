using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;

namespace RomanNumeralsKata.Tests
{
    public class RomanNumeralToNumberTests
    {
        private RomanNumeralConversion _numeralToNumber;

        [SetUp]
        public void Setup()
        {
            _numeralToNumber = new RomanNumeralConversion();
        }

        [Test]
        public void Should_Return_Minus_One_When_Invalid_Numeral_Provided()
        {
            _numeralToNumber.Convert("XFDR").Should().Be(-1);
        }

        [Test]
        public void When_Entered_IV_Numeral_Number_Four_Should_Be_Returned()
        {
            _numeralToNumber.Convert("IV").Should().Be(4);
        }

    }
}
