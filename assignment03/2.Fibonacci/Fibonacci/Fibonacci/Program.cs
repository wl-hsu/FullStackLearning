using System.Numerics;

public class Program
{
    public static void Main(string[] args)
    {
        int fibonacciIndex;
        do
        {
            Console.WriteLine("Enter the index of fibonacci sequence(must > 0):");
        } while (!int.TryParse(Console.ReadLine(), out fibonacciIndex) || fibonacciIndex <= 0);

        BigInteger[] FibonacciArray = GenerateFibonacciSequence(fibonacciIndex);
        Console.WriteLine(FibonacciArray[fibonacciIndex - 1]);

    }

    public static BigInteger[] GenerateFibonacciSequence(int fibonacciIndex)
    {
        BigInteger[] FibonacciArray = new BigInteger[fibonacciIndex];
        if (fibonacciIndex == 1)
        {
            FibonacciArray[0] = 1;
            return FibonacciArray;
        }
        if (fibonacciIndex == 2)
        {
            FibonacciArray[0] = 1;
            FibonacciArray[1] = 1;
            return FibonacciArray;
        }
        FibonacciArray[0] = 1; 
        FibonacciArray[1] = 1;
        for (int i = 2; i < FibonacciArray.Length; i++)
        {
            FibonacciArray[i] = FibonacciArray[i - 1] + FibonacciArray[i - 2];
        }
        return FibonacciArray;
    }

}

