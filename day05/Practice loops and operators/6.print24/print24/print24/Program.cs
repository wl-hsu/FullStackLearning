for (int i = 1; i <= 4; i += 1)
{
    int j = i;
    Console.Write(0+ " ");
    Console.Write(i + " ");
    for (j = 2; j <= 24; j++)
    {
        if (j * i > 24)
        {
            break;
        }
        Console.Write(j * i + " ");
    }
    Console.WriteLine();
    
}