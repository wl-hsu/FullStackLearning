using System.Text;

class Program
{
    public static void Main()
    {
        string test = "C# is not C++, and PHP is not Delphi!";
        //string[] words = test.Split(" ");
        String words = ReverseWords(test);
        Console.WriteLine(words);

    }

    public static string ReverseWords(string str)
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


}