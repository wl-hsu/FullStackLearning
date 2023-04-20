public class Program
{
    public static void Main()
    {
        int[] input = { 7, 7, 7, 0, 2, 2, 2, 0, 10, 10, 10 };
        int n = input.Length;
        int maxLength = 1;
        int maxElement = input[0];
        int currentLength = 1;
        int currentElement = input[0];


        /*
         * Boyer–Moore majority vote algorithm
         * leetcode 169
         */
        for (int i = 1; i < n; i++)
        {
            if (input[i] == input[i - 1])
            {
                currentLength++;
                currentElement = input[i];
            }
            else
            {
                if (currentLength > maxLength)
                {
                    maxLength = currentLength;
                    maxElement = currentElement;
                }
                currentLength = 1;
                currentElement = input[i];
            }
        }

        if (currentLength > maxLength)
        {
            maxLength = currentLength;
            maxElement = currentElement;
        }

        Console.WriteLine("most frequent element:");
        Console.Write(maxElement);

    }
}