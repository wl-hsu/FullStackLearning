using System.Collections;
using System.Collections.Generic;


class CmdReader
{
    public string CmdController() {
            string input = null;
    bool validInput = false;

    while (!validInput)
    {
        Console.Write("\nPlease enter a instruction \n + some item\n - some item\n -- \n");
        input = Console.ReadLine();

        if (input == "+" || input == "-" || input == "--")
        {
            validInput = true;
            Console.WriteLine("You entered a instruction: " + input);
        }
        else
{
    Console.WriteLine("Invalid input, try again.");
}
    }
    return input;
}


}

class Program 
  
{
    public static void Main(string[] args)
    {
        ArrayList strList = new ArrayList();
        CmdReader reader = new CmdReader();
        while (true) {
            string insturction = reader.CmdController();
            if (insturction == "+")
            {
                strList.Add(insturction);
                Console.WriteLine("Elements in array are:");
                foreach (string str in strList)
                {
                    Console.Write(str);
                }
            } else if (insturction == "-")
            {
                if (strList.Count > 0)
                {
                    strList.RemoveAt(strList.Count - 1);
                    if (strList.Count > 0)
                    {
                        Console.WriteLine("Elements in array are:");
                        foreach (string str in strList)
                        {
                            Console.Write(str);
                        }

                    } else
                    {
                        Console.WriteLine("List is already empty.");
                    }

                } else
                {
                    Console.WriteLine("List is already empty.");
                }

            } else
            {
                Console.WriteLine("Elements in array have been cleared.");
                strList.Clear();
            }
        }
        
    }

}
