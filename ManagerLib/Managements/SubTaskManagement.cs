using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using ManagerLib.Entities;
using ManagerLib.Repositories;
using ManagerLib.User;
#pragma warning disable

namespace ManagerLib.Managements
{
    public class SubTaskManagement
    {
        public Task Task;

        public SubTaskManagement(Task task)
        {
            Task = task;
        }

        public void Show()
        {
            bool isNotEnd = true;
            while (isNotEnd)
            {
                Console.Clear();
                Console.WriteLine("\t\t\t▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬");
                Console.WriteLine("\t\t\t▌     Sub-Task");
                Console.WriteLine("\t\t\t▌  [L]ist sub-tasks:");
                Console.WriteLine("\t\t\t▌  [A]dd sub-task:");
                Console.WriteLine("\t\t\t▌  [E]dit:");
                Console.WriteLine("\t\t\t▌  [B]ack");
                Console.Write("\t\t\t▌  Type here:");
                string choice = Console.ReadLine()?.ToUpper();
                if (choice == "L")
                {
                    List();
                    break;
                }

                if (choice == "A")
                {
                    Add();
                    break;
                }
                if (choice == "E")
                {
                    EditEntity();
                    break;
                }
                if (choice == "B")
                {
                    isNotEnd = false;
                    break;
                }
                Console.WriteLine("\t\t\t▌  Invalid choice!");
            }
        }

        public void List()
        {
            try
            {
                SubTaskRepository commentRepo = new SubTaskRepository();
                List<SubTask> comments = commentRepo.GetAll(Task.Id);
                if (comments.Count > 0)
                {
                    Console.WriteLine($"\t\t\t▌  Task Id: {Task.Id}");
                    foreach (SubTask comment in comments)
                    {
                        Console.WriteLine($"\t\t\t▌  ID: {comment.Id}");
                        Console.WriteLine($"\t\t\t▌  Task id: {comment.SubTaskId}");
                        Console.WriteLine($"\t\t\t▌  Title: {comment.Title}");
                        Console.WriteLine($"\t\t\t▌  Task Priority: {comment.TaskStatus}");
                        Console.WriteLine($"\t\t\t▌  Description: {comment.Description}");
                        Console.WriteLine($"\t\t\t▌  Working Hours: {comment.WorkingHours}");
                        Console.WriteLine($"\t\t\t▌  Last Edit Date: {comment.LastEditDate}");
                        Console.WriteLine($"\t\t\t▌  Status: {comment.Status}");
                    }
                }
                else
                {
                    Console.WriteLine("You currently don't have any sub-tasks..");
                    Console.WriteLine("Press any key to continue...");
                }
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        protected void EditEntity()
        {
            try
            {
                SubTaskRepository newRepository = new SubTaskRepository();
                List<SubTask> newSubTasks = newRepository.GetAll(Task.Id);
                Console.WriteLine($"\t\t\t▌  Project Id contains: {Task.Id}");
                foreach (SubTask comment in newSubTasks)
                {
                    Console.WriteLine($"\t\t\t▌  ID: {comment.Id}");
                    Console.WriteLine($"\t\t\t▌  Responsible: {comment.ResponsibleId}");
                    Console.WriteLine($"\t\t\t▌  Title: {comment.Title}");
                    Console.WriteLine($"\t\t\t▌  Task Priority: {comment.TaskStatus}");
                    Console.WriteLine($"\t\t\t▌  Description: {comment.Description}");
                    Console.WriteLine($"\t\t\t▌  Working Hours: {comment.WorkingHours}");
                    Console.WriteLine($"\t\t\t▌  Last Edit Date: {comment.LastEditDate}");
                    Console.WriteLine($"\t\t\t▌  Status: {comment.Status}");
                }
                Console.Write("\t\t\t▌  Which sub-task id do you want to edit?: ");
                int inputId = int.Parse(Console.ReadLine());
                List<SubTask> comments = newRepository.GetAll(inputId);
                foreach (var task in comments)
                {
                    Console.WriteLine($"\t\t\t▌  Title: {task.Title}");
                    Console.Write("\t\t\t▌  New Title: ");
                    task.Title = Console.ReadLine();
                    Console.WriteLine($"\t\t\t▌  Description: {task.Description}");
                    Console.Write("\t\t\t▌  New Description: ");
                    task.Description = Console.ReadLine();
                    Console.WriteLine($"\t\t\t▌  Responsible: {task.ResponsibleId}");
                    Console.WriteLine($"\t\t\t▌  New Responsible:");
                    UserRepository userRepository = new UserRepository();
                    List<Entities.User> users = userRepository.GetAll();
                    Console.Write("\t\t\t▌  ");
                    foreach (var user in users)
                    {
                        Console.Write(user.Username + " ");
                    }
                    Console.Write("\n\t\t\t▌  Type here:");
                    string userInput = Console.ReadLine();
                    foreach (var user in users.Where(user => userInput != null && userInput.Contains(user.Username)))
                    {
                        task.ResponsibleId = user.Username;
                    }

                    Console.Write($"\t\t\t▌  Working Hours: {task.WorkingHours}");
                    Console.Write("\t\t\t▌  New Working Hours: ");
                    task.WorkingHours = IntegerValidation();
                    task.LastEditDate = DateTime.Now;
                    Console.Write($"\t\t\t▌  Current Priority: {task.TaskStatus}");
                    Console.Write("\t\t\t▌  New Task Priority [1]Epic, [2]Task, [3]Bug, [4]Story: ");
                    string statusTask = Console.ReadLine() ?? string.Empty;
                   

                    Console.Write($"\t\t\t▌  Current Status: {task.Status}");
                    Console.Write("\t\t\t▌  Status InProgress - [1] or Finished - [2] or Opened [3]: ");
                    string input = Console.ReadLine() ?? string.Empty;
                    switch (input)
                    {
                        case "1":
                            task.Status = (SubTaskStatus)Enum.Parse(typeof(SubTaskStatus), "InProgress");
                            break;
                        case "2":
                            task.Status = (SubTaskStatus)Enum.Parse(typeof(SubTaskStatus), "Finished");
                            break;
                        case "3":
                            task.Status = (SubTaskStatus)Enum.Parse(typeof(SubTaskStatus), "Opened");
                            break;
                        default:
                            Console.WriteLine("\t\t\t▌  Auto-Selected Default");
                            task.Status = (SubTaskStatus)Enum.Parse(typeof(SubTaskStatus), "Opened");
                            break;
                    }

                    Console.WriteLine($"\t\t\t▌  Sub-task changed!");
                    Console.ReadKey();
                    newRepository.Add(task);
                }

            }
            catch (Exception ex)
            {
            }
        }

        private static int IntegerValidation()
        {
            int entityId;
            do
            {
            } while (!int.TryParse(Console.ReadLine(), out entityId) || entityId <= 0);

            return entityId;
        }

        private void Add()
        {
            Console.Clear();

            try
            {
                SubTaskRepository newRepository = new SubTaskRepository();
                List<SubTask> newSubTasks = newRepository.GetAll(Task.Id);
                Console.Write("\t\t\t▌  How many sub-tasks do you want to create: ");
                Task.CountTask = IntegerValidation();
                for (int i = 0; i < Task.CountTask; i++)
                {
                    SubTaskRepository commentRepo = new SubTaskRepository();
                    SubTask subTask = new SubTask
                    {
                        SubTaskId = Task.Id,
                        Description = Task.Description,
                        WorkingHours = Task.WorkingHours,
                    };

                    Console.WriteLine($"\t\t\t▌   {i} Task");
                    Console.Write("\t\t\t▌  Title: ");
                    subTask.Title = Console.ReadLine();
                    Console.Write("\t\t\t▌  Description: ");
                    subTask.Description = Console.ReadLine();
                    Console.WriteLine("\t\t\t▌  Choose Responsible Username: ");
                    UserRepository userRepository = new UserRepository();
                    List<Entities.User> users = userRepository.GetAll();
                    Console.Write("\t\t\t▌  ");
                    foreach (var user in users)
                    {
                        Console.Write(user.Username + " ");
                    }
                    Console.Write("\n\t\t\t▌  Type here: ");
                    subTask.CreatorId = Console.ReadLine();
                    Console.Write("\t\t\t▌  Working Hours: ");
                    subTask.WorkingHours = IntegerValidation();
                    subTask.LastEditDate = DateTime.Now;
                    Console.Write("\t\t\t▌  Task Priority [1]Epic, [2]Task, [3]Bug, [4]Story: ");
                    int statusTask = IntegerValidation();
                    switch (statusTask)
                    {
                        case 1:
                            subTask.TaskStatus = (TaskStatusEnum)Enum.Parse(typeof(TaskStatusEnum), "Epic");
                            break;
                        case 2:
                            subTask.TaskStatus = (TaskStatusEnum)Enum.Parse(typeof(TaskStatusEnum), "Task");
                            break;
                        case 3:
                            subTask.TaskStatus = (TaskStatusEnum)Enum.Parse(typeof(TaskStatusEnum), "Bug");
                            break;
                        case 4:
                            subTask.TaskStatus = (TaskStatusEnum)Enum.Parse(typeof(TaskStatusEnum), "Story");
                            break;
                        default:
                            Console.WriteLine("\t\t\t▌  Auto-Selected Default");
                            subTask.TaskStatus = (TaskStatusEnum)Enum.Parse(typeof(TaskStatusEnum), "Task");
                            break;
                    }

                    Console.Write("\t\t\t▌  Status Project = InProgress - [1] or Finished - [2] or Opened [3]: ");
                    int input = IntegerValidation();
                    switch (input)
                    {
                        case 1:
                            subTask.Status = (SubTaskStatus)Enum.Parse(typeof(SubTaskStatus), "InProgress");
                            break;
                        case 2:
                            subTask.Status = (SubTaskStatus)Enum.Parse(typeof(SubTaskStatus), "Finished");
                            break;
                        case 3:
                            subTask.Status = (SubTaskStatus)Enum.Parse(typeof(SubTaskStatus), "Opened");
                            break;
                        default:
                            Console.WriteLine("\t\t\t▌  Auto-Selected Default");
                            subTask.Status = (SubTaskStatus)Enum.Parse(typeof(SubTaskStatus), "Opened");
                            break;
                    }
                    Console.WriteLine("\t\t\t▌  Sub-task created!");
                    Console.ReadKey();
                    commentRepo.Add(subTask);
                }
            }
            catch (Exception ex)
            {
            }
        }
    }
}