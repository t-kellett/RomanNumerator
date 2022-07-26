namespace RomanNumerator;

public class Numerator
{
    static Dictionary<int, string> NumberToRoman = new Dictionary<int, string>
    {
        { 1000, "M" },
        { 900, "CM" },
        { 500, "D" },
        { 400, "CD" },
        { 100, "C" },
        { 90, "XC" },
        { 50, "L" },
        { 40, "XL" },
        { 10, "X" },
        { 9, "IX" },
        { 6, "VI" },
        { 5, "V" },
        { 4, "IV" },
        { 1, "I" }
    };

    public static string Convert(int i)
    {
        string output = "";

        foreach (var value in NumberToRoman.Keys)
        {
            while (i >= value)
            {
                output += NumberToRoman[value];
                i -= value;
            }
        }

        return output;
    }

}

