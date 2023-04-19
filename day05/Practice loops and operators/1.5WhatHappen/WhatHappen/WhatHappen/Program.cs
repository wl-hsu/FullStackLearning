int max = 500;
/**
 * This code will become infinite loop
 * beacuse i go over the upper number of byte and it re-start from the lowest 
 * number in byte. It never touch 500. Like 0 1 2 3 ... 255 0 1 2 3...254 255 0 1 2...
for (byte i = 0; i < max; i++)
{
    Console.WriteLine(i);
}

 */

for (byte i = 0; i < max; i++)
{
    if (i < max && i == 255)
    {
        Console.WriteLine(i);
        Console.WriteLine("primitive type byte is too small for max");
        break;
    }
    Console.WriteLine(i);
}
