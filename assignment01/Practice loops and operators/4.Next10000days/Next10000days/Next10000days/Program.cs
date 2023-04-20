// birthday is 2008/3/1
var birthday = new DateTime(2008, 3, 1);
// get today date
var today = DateTime.Today;
// get age
var age = today.Year - birthday.Year;
// get how many days so far
var days = (today.Date - birthday.Date).Days;
int gapForNext1000Days = 10000 - (days % 10000);
var dateToNextAnniversary = today.AddDays(gapForNext1000Days);
Console.WriteLine(dateToNextAnniversary);

