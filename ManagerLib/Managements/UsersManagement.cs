using System;
using ManagerLib.Repositories;

#pragma warning disable

namespace ManagerLib.Managements
{
    public class UsersManagement : BaseManagement<Entities.User>
    {
        /// <summary>
        /// Getting user-repository.
        /// </summary>
        /// <returns></returns>
        protected override BaseRepository<Entities.User> GetRepo()
        {
            UserRepository userRepo = new UserRepository();
            return userRepo;
        }

        /// <summary>
        /// Editing the User entity.
        /// </summary>
        /// <param name="user">object User</param>
        /// <returns></returns>
        protected override Entities.User EditEntity(Entities.User user)
        {
            // Part of editing. Showing previous info and the new one.
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

        /// <summary>
        /// Adding new user.
        /// </summary>
        /// <param name="user">object User</param>
        /// <returns>User</returns>
        protected override Entities.User GetEntity(Entities.User user)
        {
            Console.Write("\t\t\t▌  Username: ");
            user.Username = Console.ReadLine();
            Console.Write("\t\t\t▌  New Is admin (True - [1] , False - [2]): ");
            string isAdmin = Console.ReadLine()?.ToLower();
            // Checking through switch.
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

        /// <summary>
        /// Showing info about the user.
        /// </summary>
        /// <param name="user"></param>
        protected override void RenderEntity(Entities.User user)
        {
            Console.WriteLine($"\t\t\t▌  ID: {user.Id}");
            Console.WriteLine($"\t\t\t▌  Username: {user.Username}");
            Console.WriteLine($"\t\t\t▌  Is admin: {user.IsAdmin}");
            Console.WriteLine("\t\t\t▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬");
        }
    }
}