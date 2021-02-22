using System;
using System.Collections.Generic;
using ManagerLib.Entities;
using ManagerLib.Repositories;
using ManagerLib.User;

namespace ManagerLib.Managements
{
    public class TasksManagement : BaseManagement<Task>
    {
        public override Task Entity { get; set; }

        protected override BaseRepository<Task> GetRepo()
        {
            TaskRepository taskRepo = new TaskRepository();
            return taskRepo;
        }


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

        protected override Task GetEntity(Task task)
        {
            try
            {
                UserRepository userRepository = new UserRepository();
                Console.Write("\t\t\t▌  Title: ");
                task.Title = Console.ReadLine();
                Console.Write("\t\t\t▌  Description: ");
                task.Description = Console.ReadLine();
                Console.Write("\t\t\t▌  Working Hours: ");
                task.WorkingHours = IntegerValidation();
                task.CreatorId = LoginValidation.LoggedUser.Id;
                Console.WriteLine("\t\t\t▌  Choose Responsible Name: ");
                List<Entities.User> users = userRepository.GetAll();
                Console.Write("\t\t\t▌  ");
                foreach (var user in users)
                {
                    Console.Write(user.Username + " ");
                }
                Console.Write("\n\t\t\t▌  Type here: ");
                task.ResponsibleId = Console.ReadLine();
                task.CreateDate = DateTime.Now;
                task.LastEditDate = DateTime.Now;
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
                Console.WriteLine("\t\t\t▌  Project created!");
                Console.Write("\t\t\t▌  Do you want to add sub-tasks? [Y]es or [N]o: ");
                string choiceInput = Console.ReadLine()?.ToLower();
                if (choiceInput != null && choiceInput.Contains('y'))
                {
                    SubTaskManagement sb = new SubTaskManagement(task);
                    sb.Show();
                }
                return task;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return null;
        }

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
                SubTaskRepository subTaskRepository = new SubTaskRepository();
                List<SubTask> subTasks = subTaskRepository.GetAll(task.Id);
                if (subTasks.Count > 0)
                {
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
                Console.WriteLine("\t\t\t▌  Records:");
                RecordRepository recordRepo = new RecordRepository();
                List<Record> records = recordRepo.GetAll(task.Id);
                if (comments.Count > 0)
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

        protected override Task EditEntity(Task task)
        {
            Console.WriteLine("\t\t\t▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬");
            Console.WriteLine($"\t\t\t▌  Title: {task.Title}");
            Console.Write("\t\t\t▌  New Title: ");
            task.Title = Console.ReadLine();
            Console.WriteLine($"\t\t\t▌  Description: {task.Description}");
            Console.Write("\t\t\t▌  New Description: ");
            task.Description = Console.ReadLine();
            Console.WriteLine($"\t\t\t▌  Working Hours: {task.WorkingHours}");
            Console.Write("\t\t\t▌  New Working Hours: ");
            task.WorkingHours = IntegerValidation();

            task.LastEditDate = DateTime.Now;

            Console.WriteLine($"\t\t\t▌  Status: {task.Status}");
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

        protected override void View()
        {
            base.View();

            TasksDetailsView taskDetails = new TasksDetailsView(Entity);
            taskDetails.Show();
        }
    }
}