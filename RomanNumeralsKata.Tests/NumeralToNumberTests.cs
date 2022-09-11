namespace RomanNumeralsKata.Tests;
using RomanNumeralsKata;
using FluentAssertions;
public class Tests
{
    private RomanNumeralConversion _numeralToNumber;
    
    [SetUp]
    public void Setup()
    {
        _numeralToNumber = new RomanNumeralConversion();
    }

    [Test]
    public void When_Number_Is_Zero_Should_Return_Invalid_Number()
    {
        _numeralToNumber.Convert(0).Should().Be("For Romans 0 did not exist.");
    }

    [Test]
    public void When_Number_Is_Negative_Should_Return_Invalid_Number()
    {
        _numeralToNumber.Convert(-11).Should().Be("For Romans -11 did not exist.");
    }

    [Test]
    public void When_Number_Is_Larger_Than_3550_Should_Return_Number_Too_Large()
    {
        _numeralToNumber.Convert(4000).Should().Be("Number Too Large");
    }

    [Test]
    public void When_Number_99_Should_Return_()
    {
        _numeralToNumber.Convert(99).Should().Be("XCIX");
    }

}