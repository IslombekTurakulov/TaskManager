using System;
using System.Collections.Generic;
using System.Linq;
using ManagerLib.Entities;
using ManagerLib.Repositories;
using ManagerLib.User;

namespace ManagerLib.Managements
{
    public class TasksManagement : BaseManagement<Task>
    {
        public override Task Entity { get; set; }

        /// <summary>
        /// Getting repository of class Task.
        /// </summary>
        /// <returns></returns>
        protected override BaseRepository<Task> GetRepo()
        {
            TaskRepository taskRepo = new TaskRepository();
            return taskRepo;
        }

        /// <summary>
        /// Validating integer.
        /// </summary>
        /// <returns></returns>
        private static int IntegerValidation()
        {
            int entityId;
            do
            {
                Console.WriteLine();
                Console.Write("\t\t\t▌  Type here:");
            } while (!int.TryParse(Console.ReadLine(), out entityId) || entityId <= 0);

            return entityId;
        }


        /// <summary>
        /// Word validating
        /// </summary>
        /// <returns></returns>
        private static string WordValidator()
        {
            while (true)
            {
                Console.Write("\t\t\t▌  Type here: ");
                string input = Console.ReadLine()?.Trim();
                if (input.Length <= 3)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine();
                    Console.WriteLine("\t\t\t▌  The length should be greater than 3!");
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else
                    return input;
            }
        }
        /// <summary>
        /// Getting entity of Task.
        /// </summary>
        /// <param name="task"></param>
        /// <returns></returns>
        protected override Task GetEntity(Task task)
        {
            try
            {
                // Creating new repository of user.
                UserRepository userRepository = new UserRepository();
                Console.WriteLine("\t\t\t▌  Title");
                task.Title = WordValidator();
                Console.WriteLine("\t\t\t▌  Description");
                task.Description = WordValidator();
                Console.Write("\t\t\t▌  Working Hours: ");
                task.WorkingHours = IntegerValidation();
                task.CreatorId = LoginValidation.LoggedUser.Id;
                List<Entities.User> users = userRepository.GetAll();
                bool correct = false;
                do
                {
                    Console.WriteLine("\t\t\t▌  Choose Responsible Username: ");
                    Console.Write("\t\t\t▌  ");
                    foreach (var user in users)
                        Console.Write(user.Username + " ");
                    
                    Console.Write("\n");
                    task.ResponsibleId = WordValidator();
                    string[] names = task.ResponsibleId?.Split(' ');
                    foreach (var user in users)
                    {
                        foreach (var t in names)
                        {
                            if (t.Contains(user.Username))
                                correct = true;
                            break;
                        }
                    }
                } while (!correct);

                task.CreateDate = DateTime.Now;
                task.LastEditDate = DateTime.Now;
                // Status task.
                Console.Write("\t\t\t▌  Status task = InProgress - [1] or Finished - [2] or Opened [3]: ");
                string input = Console.ReadLine() ?? string.Empty;
                switch (input)
                {
                    case "1":
                        task.Status = (StatusEnum) Enum.Parse(typeof(StatusEnum), "InProgress");
                        break;
                    case "2":
                        task.Status = (StatusEnum) Enum.Parse(typeof(StatusEnum), "Finished");
                        break;
                    case "3":
                        task.Status = (StatusEnum) Enum.Parse(typeof(StatusEnum), "Opened");
                        break;
                    default:
                        Console.WriteLine("Auto-Selected Default");
                        task.Status = (StatusEnum) Enum.Parse(typeof(StatusEnum), "Opened");
                        break;
                }
                // End of adding.
                Console.WriteLine("\t\t\t▌  Project created!");
                // Part of choice of sub-tasks.
                Console.WriteLine("\t\t\t▌  If you want to add sub-task, go View -> Select ID");
                return task;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return null;
        }

        /// <summary>
        /// Rendering (Showing information)
        /// </summary>
        /// <param name="task"></param>
        protected override void RenderEntity(Task task)
        {
            try
            {
                Console.WriteLine("\t\t\t▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬");
                Console.WriteLine($"\t\t\t▌  ID: {task.Id}");
                Console.WriteLine($"\t\t\t▌  Title: {task.Title}");
                Console.WriteLine($"\t\t\t▌  Description: {task.Description}");
                Console.WriteLine($"\t\t\t▌  Working Hours: {task.WorkingHours}");
                Console.WriteLine($"\t\t\t▌  Creator ID: {task.CreatorId}");
                Console.WriteLine($"\t\t\t▌  Responsible: {task.ResponsibleId}");
                Console.WriteLine($"\t\t\t▌  Created Date: {task.CreateDate}");
                Console.WriteLine($"\t\t\t▌  Last Edit Date: {task.LastEditDate}");
                Console.WriteLine($"\t\t\t▌  Status: {task.Status}");
                Console.WriteLine("\t\t\t▌  Sub-Tasks:");
                // Creating new repository class.
                SubTaskRepository subTaskRepository = new SubTaskRepository();
                // Adding to list of SubTasks.
                List<SubTask> subTasks = subTaskRepository.GetAll(task.Id);
                if (subTasks.Count > 0)
                {
                    // Showing info.
                    foreach (SubTask subTask in subTasks)
                    {
                        Console.WriteLine($"\t\t\t\t▌  ID: {subTask.Id}");
                        Console.WriteLine($"\t\t\t\t▌  Title: {subTask.Title}");
                        Console.WriteLine($"\t\t\t\t▌  Task Priority: {subTask.TaskStatus}");
                        Console.WriteLine($"\t\t\t\t▌  Description: {subTask.Description}");
                        Console.WriteLine($"\t\t\t\t▌  Working Hours: {subTask.WorkingHours}");
                        Console.WriteLine($"\t\t\t\t▌  Creator ID: {subTask.CreatorId}");
                        Console.WriteLine($"\t\t\t\t▌  Last Edit Date: {subTask.LastEditDate}");
                        Console.WriteLine($"\t\t\t\t▌  Status: {subTask.Status}");
                    }
                }

                Console.WriteLine("\t\t\t▬▬▬▬▬▬▬▬▬▬▬▬▬▬");
                Console.WriteLine("\t\t\t▌  Epic Sub-Tasks:");
                // Creating new repository class.
                EpicRepository epicRepository = new EpicRepository();
                // Adding to list of SubTasks.
                List<EpicTask> epicTasks = epicRepository.GetAll(task.Id);
                if (epicTasks.Count > 0)
                {
                    // Showing info.
                    foreach (EpicTask epicTask in epicTasks)
                    {
                        Console.WriteLine($"\t\t\t\t▌  ID: {epicTask.Id}");
                        Console.WriteLine($"\t\t\t\t▌  Title: {epicTask.Title}");
                        Console.WriteLine($"\t\t\t\t▌  Task Priority: {epicTask.Priority}");
                        Console.WriteLine($"\t\t\t\t▌  Description: {epicTask.Description}");
                        Console.WriteLine($"\t\t\t\t▌  Working Hours: {epicTask.WorkingHours}");
                        Console.WriteLine($"\t\t\t\t▌  Creator ID: {epicTask.CreatorId}");
                        Console.WriteLine($"\t\t\t\t▌  Last Edit Date: {epicTask.LastEditDate}");
                        Console.WriteLine($"\t\t\t\t▌  Status: {epicTask.Status}");
                    }
                }
                Console.WriteLine("\t\t\t▬▬▬▬▬▬▬▬▬▬▬▬▬▬");
                // Showing info about comments.
                Console.WriteLine("\t\t\t▌  Comments:");
                CommentRepository commentRepo = new CommentRepository();
                List<Comment> comments = commentRepo.GetAll(task.Id);
                if (comments.Count > 0)
                {
                    foreach (Comment comment in comments)
                    {
                        Console.WriteLine($"\t\t\t▌  Text: {comment.Text}");
                        Console.WriteLine($"\t\t\t▌  Created Date: {comment.CreateDate}");
                    }
                }
                // Showing info about records.
                Console.WriteLine("\t\t\t▌  Records:");
                RecordRepository recordRepo = new RecordRepository();
                List<Record> records = recordRepo.GetAll(task.Id);
                if (records.Count > 0)
                {
                    foreach (Record record in records)
                    {
                        Console.WriteLine($"\t\t\t▌  Working Hours: {record.WorkingHours}");
                        Console.WriteLine($"\t\t\t▌  Created Date: {record.CreateDate}");
                    }
                }
                Console.WriteLine("\t\t\t▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// Editing Task entity.
        /// </summary>
        /// <param name="task">object Task</param>
        /// <returns></returns>
        protected override Task EditEntity(Task task)
        {
            // Part of showing previous tasks and editing to new one.
            Console.WriteLine("\t\t\t▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬");
            Console.WriteLine($"\t\t\t▌  Title: {task.Title}");
            Console.Write("\t\t\t▌  New Title: ");
            task.Title = WordValidator();
            Console.WriteLine($"\t\t\t▌  Description: {task.Description}");
            Console.Write("\t\t\t▌  New Description: ");
            task.Description = WordValidator();
            Console.WriteLine($"\t\t\t▌  Working Hours: {task.WorkingHours}");
            Console.Write("\t\t\t▌  New Working Hours: ");
            task.WorkingHours = IntegerValidation();

            task.LastEditDate = DateTime.Now;

            Console.WriteLine($"\t\t\t▌  Status: {task.Status}");
            // Status task.
            Console.Write("\t\t\t▌  Status task = InProgress - [1] or Finished - [2] or Opened [3]: ");
            string input = Console.ReadLine() ?? string.Empty;
            switch (input)
            {
                case "1":
                    task.Status = (StatusEnum)Enum.Parse(typeof(StatusEnum), "InProgress");
                    break;
                case "2":
                    task.Status = (StatusEnum)Enum.Parse(typeof(StatusEnum), "Finished");
                    break;
                case "3":
                    task.Status = (StatusEnum)Enum.Parse(typeof(StatusEnum), "Opened");
                    break;
                default:
                    Console.WriteLine("Auto-Selected Default");
                    task.Status = (StatusEnum)Enum.Parse(typeof(StatusEnum), "Opened");
                    break;
            }
            Console.WriteLine("\t\t\t▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬");
            return task;
        }

        /// <summary>
        /// View the task.
        /// </summary>
        protected override void View()
        {
            base.View();

            TasksDetailsView taskDetails = new TasksDetailsView(Entity);
            taskDetails.Show();
        }
    }
}