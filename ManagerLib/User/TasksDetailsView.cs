using System;
using ManagerLib.Entities;
using ManagerLib.Managements;

namespace ManagerLib.User
{
    public class TasksDetailsView
    {
        public Task Task;

        public TasksDetailsView(Task task)
        {
            Task = task;
        }

        public void Show()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("\t\t\t▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬");
                Console.WriteLine("\t\t\t▌  [R]ecords Management");
                Console.WriteLine("\t\t\t▌  [C]omments Management");
                Console.WriteLine("\t\t\t▌  [S]ub-Tasks Management");
                Console.WriteLine("\t\t\t▌  [B]ack");
                Console.Write("\t\t\t▌  Type here: ");
                string choice = Console.ReadLine()?.ToUpper();

                if (choice == "R")
                {
                    RecordsManagement records = new RecordsManagement(Task);
                    records.Show();
                    break;
                }
                if (choice == "C")
                {
                    CommentsManagement comments = new CommentsManagement(Task);
                    comments.Show();
                    break;
                }
                if (choice == "S")
                {
                    SubTaskManagement comments = new SubTaskManagement(Task);
                    comments.Show();
                    break;
                }
                if (choice == "B")
                {
                    TasksManagement tasksManagement = new TasksManagement();
                    tasksManagement.Show();
                    break;
                }
                Console.WriteLine("\t\t\t▌  Invalid choice!");
                Console.ReadKey();
            }
        }
    }

}
