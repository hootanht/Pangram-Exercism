using System.Linq;
using System.Text;
public static class Pangram
{
    const int TOTAL_ASCII_CHARS = 26;
    public static bool IsPangram(string input)
    {
        int count = OnlyASCII(input).ToLower()
                                    .Where((c) => char.IsLetter(c))
                                    .Distinct()
                                    .Count();
        return count == TOTAL_ASCII_CHARS;
    }
    static string OnlyASCII(string input)
    {
        return Encoding.ASCII.GetString(Encoding.ASCII.GetBytes(input));
    }
}