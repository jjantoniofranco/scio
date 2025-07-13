using System.Text;

namespace Encoder;

public static class RunLengthEncoder
{
    public static string Encode(string toEncode)
    {
        if (string.IsNullOrEmpty(toEncode))
            return string.Empty;

        var sb = new StringBuilder();
        char initialChar = toEncode[0];
        int count = 1;

        for (int i = 1; i < toEncode.Length; i++)
        {
            char currentChar = toEncode[i];
            if (currentChar == initialChar)
            {
                count++;
            }
            else
            {
                sb.Append(count).Append(initialChar);
                initialChar = currentChar;
                count = 1;
            }
        }
        sb.Append(count).Append(initialChar);
        return sb.ToString();
    }
}
