using System.Numerics;

int centuries = 0;
do
{
    Console.WriteLine("Enter a number:");
} while (!int.TryParse(Console.ReadLine(), out centuries));

int years = centuries * 100;
int days = (int)(years * 365.2422);
long hours = (long)(days * 24);
long minutes = hours * 60;
ulong seconds = (ulong)(minutes * 60);
ulong miliseconds = (ulong)(seconds * 1000);
Decimal microseconds = miliseconds * 1000;
Decimal nanoseconds = microseconds * 1000;
Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes = {seconds} seconds = {miliseconds} milliseconds = {microseconds} microseconds = {nanoseconds} nanoseconds");
