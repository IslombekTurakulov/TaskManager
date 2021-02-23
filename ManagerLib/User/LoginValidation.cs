using System;
using System.IO;
using ManagerLib.Managements;
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
            if (username.ToLower() == "tester")
            {
                Entities.User entity = new Entities.User()
                {
                    Id = 1,
                    CreateDate = DateTime.Now,
                    IsAdmin = true,
                    Username = "tester"
                };

                UserRepository userRepository = new UserRepository();

                userRepository.Add(entity);
            }
            
            UserRepository userRepo = new UserRepository();

            LoggedUser = userRepo.GetByUsername(username);
        }
    }
}
