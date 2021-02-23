using System;
using System.IO;
using ManagerLib.Repositories;

namespace ManagerLib.User
{
    public static class LoginValidation
    {
        // It required to check sevelar things.
        // To save, verify, open.
        public static Entities.User LoggedUser { get; set; }

        /// <summary>
        /// Login method.
        /// </summary>
        /// <param name="username"></param>
        public static void Login(string username)
        {
            bool userContains = true;
            // Checking the user "tester"
            if (username.ToLower() == "tester")
            {
                // Creating new object.
                Entities.User entity = new Entities.User()
                {
                    Id = 1,
                    CreateDate = DateTime.Now,
                    IsAdmin = true,
                    Username = "tester"
                };

                // And that's the verify proccess.
                // If this user contains on this file => break.
                UserRepository userRepository = new UserRepository();
                using FileStream fs = new FileStream("users.txt", FileMode.OpenOrCreate);
                using StreamReader sr = new StreamReader(fs);
                while (!sr.EndOfStream)
                {
                    Entities.User user = GetEntity(sr);

                    if (user != null)
                    {
                        if (username != user.Username)
                            continue;
                        userContains = false;
                    }
                    else
                    {
                        break;
                    }
                }
                sr.Close();

                // If user contains == false
                if (userContains)
                    userRepository.Add(entity);
            }

            UserRepository userRepo = new UserRepository();

            LoggedUser = userRepo.GetByUsername(username);
        }

        /// <summary>
        /// Gets the all entity info about the user.
        /// </summary>
        /// <param name="sr"></param>
        /// <returns></returns>
        private static Entities.User GetEntity(StreamReader sr)
        {
            try
            {
                var user = new Entities.User
                {
                    Id = int.Parse(sr.ReadLine() ?? string.Empty),
                    Username = sr.ReadLine(),
                    IsAdmin = Convert.ToBoolean(sr.ReadLine())
                };

                return user;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return null;
        }
    }
}
