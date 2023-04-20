class Program
{
    
    static int[] FindPrimesInRange(int startNum, int endNum)
    {
        List<int> primesList = new List<int>();
        for (int num = startNum; num <= endNum; num++)
        {
            bool isPrime = true;
            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }

            if (isPrime && num > 1)
            {
                primesList.Add(num);
            }
        }

        return primesList.ToArray();
    }

    public static void Main(string[] args)
    {

        int[] ourPrimeArray = FindPrimesInRange(1, 100);
        foreach(int num in ourPrimeArray)
        {
            Console.Write(num + " ");
        }
        
    }


}