class Program
{
    public static string CmdReader(string instruction)
    {
        Console.Write(instruction);
        string cmd = Console.ReadLine();
        return cmd;
    }

    public class User
    {
        public bool isUserLogin;

        public void Login()
        {
            string username;
            string password;

            username = CmdReader("username: ");
            password = CmdReader("password: ");
            if (username != "admin" || password != "admin")
            {
                Console.WriteLine("username or password is incorrected");
                return;
            }

            isUserLogin = true;
        }
    }

    public class Menu
    {
        public void ShowMenu()
        {
            bool isExit = false;
            while (!isExit)
            {
                string selection = CmdReader("Main menu\n1.Customer management\n2.Booking\n3.System setting\n4.Exit\nChoose service: ");
                switch (selection)
                {
                    case "1":
                        Console.WriteLine("Customer management");
                        break;
                    case "2":
                        Console.WriteLine("Booking");
                        break;
                    case "3":
                        Console.WriteLine("System setting");
                        break;
                    case "4":
                    default:
                        Console.WriteLine("Exit");
                        isExit = true;
                        break;
                }
            }
        }
    }

    public class CMSController
    {
        public void Start(User user, Menu menu)
        {
            // login
            do
            {
                user.Login();
            } while (!user.isUserLogin);

            // start Menu
            menu.ShowMenu();
        }

    }

    public static void Main(string[] args)
    {
        
        User user = new User();

        Menu menu = new Menu();

        CMSController controller = new CMSController();

        controller.Start(user, menu);

        Console.Read();
    }
}