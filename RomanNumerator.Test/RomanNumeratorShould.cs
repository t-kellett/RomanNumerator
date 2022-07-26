using RomanNumerator;

namespace RomanNumerator.Test;

public class Tests
{
    [TestCase(1, "I")]
    [TestCase(2, "II")]
    [TestCase(3, "III")]
    [TestCase(4, "IV")]
    [TestCase(5, "V")]
    [TestCase(6, "VI")]
    [TestCase(7, "VII")]
    [TestCase(8, "VIII")]
    [TestCase(9, "IX")]
    [TestCase(10, "X")]
    [TestCase(11, "XI")]
    [TestCase(24, "XXIV")]
    [TestCase(38, "XXXVIII")]
    [TestCase(40, "XL")]
    [TestCase(50, "L")]
    [TestCase(90, "XC")]
    [TestCase(100, "C")]
    [TestCase(400, "CD")]
    [TestCase(500, "D")]
    [TestCase(900, "CM")]
    [TestCase(1000, "M")]
    [TestCase(2499, "MMCDXCIX")]
    [TestCase(3949, "MMMCMXLIX")]

    public void ShouldConvertIntegerToNumerals(int input, string output)
    {
        Assert.That(Numerator.Convert(input), Is.EqualTo(output));
    }
}
