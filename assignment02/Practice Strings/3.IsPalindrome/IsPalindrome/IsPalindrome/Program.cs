class Program {
    public static void Main()
    {
        Console.Write("Enter a text: ");
        string input = Console.ReadLine();
        char[] spliter = { ' ', '.', ',', ':', ';', '=', '(', ')', '&', '[', ']', '"', '\'', '\\', '/', '!', '?' };
        string[] words = input.Split(spliter, StringSplitOptions.RemoveEmptyEntries);

        List<string> palindromes = new List<string>();
        foreach (string word in words)
        {
            if (IsPalindrome(word))
            {
                palindromes.Add(word);
            }
        }
        Console.WriteLine(string.Join(", ", palindromes));

    }

    // leetcode 125. Valid Palindrome
    public static bool IsPalindrome(string s)
    {
        int left = 0, right = s.Length - 1;
        while (left < right)
        {
            while (left < right && !char.IsLetterOrDigit(s[left]))
            {
                left++;
            }
            while (left < right && !char.IsLetterOrDigit(s[right]))
            {
                right--;
            }
            if (left < right)
            {
                if (s[left] != s[right])
                {
                    return false;
                }
                left++;
                right--;
            }
        }
        return true;
    }
}
