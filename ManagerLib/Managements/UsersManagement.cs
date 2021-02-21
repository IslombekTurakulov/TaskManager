using System;
using ManagerLib.Repositories;

#pragma warning disable

namespace ManagerLib.Managements
{
    public class UsersManagement : BaseManagement<Entities.User>
    {
        protected override BaseRepository<Entities.User> GetRepo()
        {
            UserRepository userRepo = new UserRepository();
            return userRepo;
        }

        protected override Entities.User EditEntity(Entities.User user)
        {
            Console.WriteLine($"\t\t\t▌  Editing User: {user.Username}");
            Console.WriteLine($"\t\t\t▌  ID: {user.Id}");

            Console.WriteLine($"\t\t\t▌  Username: {user.Username}");
            Console.Write("\t\t\t▌  New Username: ");
            user.Username = Console.ReadLine();
            Console.WriteLine($"\t\t\t▌  Is admin: {user.IsAdmin}");
            Console.Write("\t\t\t▌  New Is admin (True - [1] , False - [2]): ");
            string isAdmin = Console.ReadLine()?.ToLower();
            switch (isAdmin)
            {
                case "1":
                    user.IsAdmin = true;
                    break;
                case "2":
                    user.IsAdmin = false;
                    break;
                default:
                    Console.WriteLine("\t\t\t▌  Auto-Selected False");
                    user.IsAdmin = false;
                    break;
            }


            return user;
        }

        protected override Entities.User GetEntity(Entities.User user)
        {
            Console.Write("\t\t\t▌  Username: ");
            user.Username = Console.ReadLine();
            Console.Write("\t\t\t▌  New Is admin (True - [1] , False - [2]): ");
            string isAdmin = Console.ReadLine()?.ToLower();
            switch (isAdmin)
            {
                case "1":
                    user.IsAdmin = true;
                    break;
                case "2":
                    user.IsAdmin = false;
                    break;
                default:
                    Console.WriteLine("\t\t\t▌  Auto-Selected False");
                    user.IsAdmin = false;
                    break;
            }

            return user;
        }

        protected override void RenderEntity(Entities.User user)
        {
            Console.WriteLine($"\t\t\t▌  ID: {user.Id}");
            Console.WriteLine($"\t\t\t▌  Username: {user.Username}");
            Console.WriteLine($"\t\t\t▌  Is admin: {user.IsAdmin}");
            Console.WriteLine("\t\t\t▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬");
        }
    }
}