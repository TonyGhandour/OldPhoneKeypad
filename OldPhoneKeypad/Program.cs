using System;

public class PhoneKeypad
{
    public Dictionary<char, string> digitMapping = new Dictionary<char, string>()
    {
        {'1', "&'("}, {'2', "abc"},
        {'3', "def"}, {'4', "ghi"},
        {'5', "jkl"}, {'6', "mno"},
        {'7', "pqrs"}, {'8', "tuv"},
        {'9', "wxyz"}, {'0', " "}
    };

    public String OldPhonePad(string input)
    {
        string ans = ""; int i = 0;
        while (i < input.Length)
        {
            if ((input[i] < '0' || input[i] > '9') && input[i] != '*' && input[i] != '#' && input[i] != ' ') throw new Exception("Invalid Format");
            i++;
        }
        i = 0;
        while ((input[i] < '0' || input[i] > '9') && input[i] != '#') i++;
        if (input[i] == '#')
            return ans;
        while (i < input.Length)
        {
            int j = 0;
            char currentChar = input[i];
            char currentValidChar = ' ';
            while (i < input.Length && currentChar >= '1' && currentChar <= '9' && currentChar == input[i])
            {
                currentValidChar = digitMapping[input[i]][j];
                j = (j + 1) % digitMapping[input[i]].Length;
                i++;
            }
            if (currentChar == '*')
                ans = ans.Substring(0, ans.Length == 0 ? 0 : ans.Length - 1);
            else if (digitMapping.TryGetValue(currentChar, out var value))
                ans += currentValidChar;
            if (currentChar < '1' || currentChar > '9') i++;
            if (currentChar == '#') break;
        }
        return ans;
    }
}