int correctNumber = new Random().Next(3) + 1;
int guessedNumber;
do
{
    Console.WriteLine("Enter a number between 1 to 3:");
} while (!int.TryParse(Console.ReadLine(), out guessedNumber) || guessedNumber > 3 || guessedNumber < 1);

if (guessedNumber > correctNumber)
{
    Console.WriteLine("too high");
} else if (guessedNumber < correctNumber)
{
    Console.WriteLine("too low");
} else
{
    Console.WriteLine("correct");
}





