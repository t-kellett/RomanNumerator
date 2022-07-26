namespace RomanNumerator;

public class Numerator
{
    static Dictionary<int, string> NumberToRoman = new Dictionary<int, string>
    {
        { 4, "IV" },
        { 9, "IX" },
        { 10, "X" }
    };

    public static string Convert(int i)
    {
        string output = "";

        if (NumberToRoman.Keys.Contains(i))
        {
            return output += NumberToRoman[i];
        }

        for (var n = 0; n < i; n++)
        {
            if (i >= 5)
            {
                output += "V";
                i -= 4;
                continue;
            }
            output += "I";
        }
        return output;
    }

}

