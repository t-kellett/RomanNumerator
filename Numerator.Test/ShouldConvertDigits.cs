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
    public void ShouldConvertIntegerToNumerals(string output, int input)
    {
        Assert.That(Numerator.Convert(input), Is.EqualTo(output));
    }
}
