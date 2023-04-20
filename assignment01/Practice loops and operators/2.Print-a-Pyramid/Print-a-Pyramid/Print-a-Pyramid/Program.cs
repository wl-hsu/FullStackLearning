int line;
do
{
    Console.WriteLine("Enter a number:");
} while (!int.TryParse(Console.ReadLine(), out line));

for (int i = 1; i <= line; i++)
{
    // print space
    for (int j = i; j < line; j++)
    {
        Console.Write(' ');
    }

    // print '*'
    for (int k = 1; k < 2 * i; k++)
    {
        Console.Write('*');
    }

    // move to next line
    Console.WriteLine();
}