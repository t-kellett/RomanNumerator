using RomanNumerator;

namespace RomanNumerator.Test;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCase("I", 1)]
    [TestCase("II", 2)]
    [TestCase("III", 3)]
    [TestCase("IV", 4)]
    [TestCase("V", 5)]
    [TestCase("VI", 6)]
    [TestCase("VII", 7)]
    [TestCase("VIII", 8)]
    [TestCase("IX", 9)]
    [TestCase("X", 10)]
    [TestCase("XI", 11)]
    [TestCase("XXIV", 24)]
    [TestCase("XXXVIII", 38)]
    [TestCase("XL", 40)]
    [TestCase("L", 50)]
    [TestCase("XC", 90)]
    [TestCase("C", 100)]
    [TestCase("CD", 400)]
    [TestCase("D", 500)]
    [TestCase("CM", 900)]
    [TestCase("M", 1000)]
    [TestCase("MMCDXCIX", 2499)]
    [TestCase("MMMCMXLIX", 3949)]

    public void ShouldConvertIntegerToNumerals(string output, int input)
    {
        Assert.That(Numerator.Convert(input), Is.EqualTo(output));
    }
}
