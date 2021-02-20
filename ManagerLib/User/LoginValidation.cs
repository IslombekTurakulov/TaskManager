using ManagerLib.Repositories;

namespace ManagerLib.User
{
    public static class LoginValidation
    {
        public static Entities.User LoggedUser { get; set; }

        public static void Login(string username)
        {
            UserRepository userRepo = new UserRepository();

            LoggedUser = userRepo.GetByUsername(username);
        }
    }


}
