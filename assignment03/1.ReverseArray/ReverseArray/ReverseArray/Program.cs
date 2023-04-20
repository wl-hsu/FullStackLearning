public class Program
{
    public static void Main(string[] args)
    {
        int sizeOfArray;
        do
        {
            Console.WriteLine("Enter a size for an array:");
        } while (!int.TryParse(Console.ReadLine(), out sizeOfArray));

        int[] numbers = GenerateNumbers(sizeOfArray);
        Reverse(numbers);
        PrintNumbers(numbers);

    }

    public static int[] GenerateNumbers(int sizeOfArray)
    {
        int[] ourArray = new int[sizeOfArray];
        for (int i = 1; i <= ourArray.Length; i++)
        {
            ourArray[i - 1] = i;
        }
        return ourArray;
    }

    public static void Reverse(int[] numbers)
    {
        int left = 0, right = numbers.Length - 1;
        while (left < right)
        {
            int temp = numbers[left];
            numbers[left] = numbers[right];
            numbers[right] = temp;
            left++;
            right--;
        }
    }
    public static void PrintNumbers(int[] numbers)
    {
        foreach (int i in numbers)
        {
            Console.Write(i + " ");
        }
    }

}

