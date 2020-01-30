using System.Collections.Generic;
using System.Text;

static class Chapter1
{
    // Is Unique
    public static bool Question1(string input)
    {
        var set = new HashSet<char>();
        foreach (var character in input)
        {
            if (set.Contains(character))
            {
                return false;
            }
            set.Add(character);
        }
        return true;
    }

    // Check Permutation
    public static bool Question2(string input1, string input2)
    {
        var dict = new Dictionary<char, int>();
        foreach (var character in input1)
        {
            if (dict.ContainsKey(character))
            {
                dict[character]++;
            }
            else
            {
                dict.Add(character, 1);
            }
        }

        foreach (var character in input2)
        {
            if (dict.ContainsKey(character))
            {
                if (--dict[character] == 0)
                {
                    dict.Remove(character);
                }
            }
            else
            {
                return false;
            }
        }

        return dict.Count == 0;
    }

    // URLify
    public static string Question3(string input)
    {
        // one liner
        //return input.Replace(" ", "%20");

        var builder = new StringBuilder();
        foreach (var character in input)
        {
            builder.Append(character == ' ' ? "%20" : character.ToString());
        }

        return builder.ToString();
    }

    // Palindrome Permutation
    public static bool Question4(string input)
    {
        var dict = new Dictionary<char, int>();

        foreach (var character in input)
        {
            if (dict.ContainsKey(character))
            {
                dict[character]++;
            }
            else
            {
                dict.Add(character, 1);
            }
        }

        bool foundOddCharacter = false;
        foreach (var count in dict.Values)
        {
            if (count % 2 == 1)
            {
                if (foundOddCharacter)
                {
                    return false;
                }
                else
                {
                    foundOddCharacter = true;
                }
            }
        }

        return true;
    }
}
