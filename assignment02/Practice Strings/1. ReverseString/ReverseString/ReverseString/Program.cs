Console.Write("Input: ");
//read input
string input = Console.ReadLine();
// to char array
char[] chars = input.ToCharArray();
// call library to reverse
Array.Reverse(chars);
// make it to a string
string reversed = new string(chars);
// print ans
Console.WriteLine("Output: " + reversed);