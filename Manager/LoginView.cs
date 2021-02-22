using System;
using ManagerLib.User;

namespace Manager
{
    public class LoginView
    {
        public void Show()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("\t\t\t▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬");
                Console.WriteLine("\t\t\t▌ Welcome to the project manager!\t▌");
                Console.WriteLine("\t\t\t▌ All the information on readme\t\t▌");
                Console.WriteLine("\t\t\t▌ Please Login\t\t\t\t▌");
                Console.WriteLine("\t\t\t▌ If you are testing please type \"tester\"▌");
                Console.Write("\t\t\t▌ Username: ");
                string username = Console.ReadLine();
                // Validating username.
                LoginValidation.Login(username);

                // Checking is user not null.
                if (LoginValidation.LoggedUser != null)
                {
                    Console.WriteLine($"\t\t\t▌ Welcome {LoginValidation.LoggedUser.Username}");
                    Console.ReadKey();
                    break;
                }

                Console.WriteLine("\t\t\t▌ Invalid username!");
                Console.ReadKey();
            }
        }
    }
}