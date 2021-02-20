using ManagerLib.Managements;
using ManagerLib.User;

namespace Manager
{
    class Program
    {
        static void Main(string[] args)
        {
            LoginView login = new LoginView();
            login.Show();

            if (LoginValidation.LoggedUser.IsAdmin)
            {
                AdminView admin = new AdminView();
                admin.Show();
                string choice = admin.Choice();

                switch (choice)
                {
                    case "U":
                    {
                        UsersManagement usersView = new UsersManagement();
                        usersView.Show();
                        break;
                    }
                    case "T":
                    {
                        TasksManagement tasks = new TasksManagement();
                        tasks.Show();
                        break;
                    }
                }
            }
            else
            {
                TasksManagement tasks = new TasksManagement();
                tasks.Show();
            }
        }
    }
}
