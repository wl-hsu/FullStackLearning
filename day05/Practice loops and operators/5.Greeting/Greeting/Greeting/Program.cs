DateTime currentDateTime = DateTime.Now;
//DateTime currentDateTime = new DateTime(2023, 4, 18, 7, 0, 0);
//DateTime currentDateTime = new DateTime(2023, 4, 18, 12, 4, 0);
//DateTime currentDateTime = new DateTime(2023, 4, 18, 18, 4, 0);
//DateTime currentDateTime = new DateTime(2023, 4, 18, 22, 4, 0);
int currentHour = currentDateTime.Hour;
int morningHour = 6;
int afternoonHour = 11;
int eveningHour = 18;
int nightHour = 22;

if (morningHour <= currentHour && currentHour < afternoonHour)
{
    Console.WriteLine("Good morning!");
}
if (afternoonHour <= currentHour && currentHour < eveningHour)
{
    Console.WriteLine("Good Afternoon!");
}
if (eveningHour <= currentHour && currentHour < nightHour)
{
    Console.WriteLine("Good Evening!");
}if (nightHour <= currentHour || currentHour < morningHour)
{
    Console.WriteLine("Good Night!");
}