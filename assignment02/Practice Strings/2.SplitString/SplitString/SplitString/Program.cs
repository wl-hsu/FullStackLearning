using System.Text;

class Program
{
    public static void Main()
    {
        string test = "C# is not C++, and PHP is not Delphi!";
        string[] words = test.Split(new char[] { ' ', '.', ',', ':', ';', '=', '(', ')', '&', '[', ']', '"', '\'', '\\', '/', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
        foreach(string word in words)
        {
            Console.WriteLine(word);
        }
    }

    public static string ReverseWords (String s)
    {
        string[] words = s.Split(new char[] { ' ' });
        Array.Reverse(words);
        string ans = string.Join(" ", words);
        return ans;

    }

    public static string ReverseWords1(string str)
    {
        StringBuilder answer = new StringBuilder();
        string[] words = str.Split('.', ' ');
        char[] x = str.ToCharArray();

        string[] punctuation = str.Split(str.ToCharArray());

        for (int position = words.Length - 1; position >= 0; position--)
        {
            answer.Append(words[position]);
            answer.Append(' ');
        }

        return answer.ToString();
    }

    public static string ReverseWords2(string str)
    {
        return String.Join(" ", str.Split('.', ' ').Reverse()).ToString();
    }
}