using System;
using System.IO;
using ManagerLib.Entities;
using ManagerLib.User;
using Newtonsoft.Json;

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
                LoginValidation.Login(username);

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