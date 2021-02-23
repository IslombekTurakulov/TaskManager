using System;
using System.Collections.Generic;
using System.Linq;
using ManagerLib.Entities;
using ManagerLib.Repositories;

namespace ManagerLib.Managements
{
    public class SubTaskManagement
    {
        // Fields.
        public Task Task;
        public SubTaskManagement(Task task) => Task = task;

        /// <summary>
        /// Show SubTask menu.
        /// </summary>
        public void Show()
        {
            while (true)
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
                    Console.WriteLine("\t\t\t▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬");
                    Console.WriteLine("\t\t\t▌  Add [E]pic task");
                    Console.WriteLine("\t\t\t▌  Add [S]ub task");
                    string taskChoice = Console.ReadLine()?.ToUpper();
                    if (taskChoice == "S")
                    {
                        Add();
                    }
                    else if (taskChoice == "E")
                    {
                        EpicAdd();
                    }
                    break;
                }
                if (choice == "E")
                {
                    EditEntity();
                    break;
                }
                if (choice == "B")
                {
                    // Goes back to task menu.
                    TasksManagement ts = new TasksManagement();
                    ts.Show();
                    break;
                }
                Console.WriteLine("\t\t\t▌  Invalid choice!");
            }
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
        /// Shows the list of subtasks.
        /// </summary>
        public void List()
        {
            try
            {
                // Creating new class of Comment repository.
                SubTaskRepository commentRepo = new SubTaskRepository();
                // Adding to list.
                List<SubTask> comments = commentRepo.GetAll(Task.Id);
                if (comments.Count > 0)
                {
                    // Showing information about sub-tasks.
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
                    Console.WriteLine("\t\t\t▌  You currently don't have any sub-tasks..");
                    Console.WriteLine("\t\t\t▌  Press any key to continue...");
                }
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// Editing the subtask field.
        /// </summary>
        protected void EditEntity()
        {
            try
            {
                // Creating new class of Comment repository.
                SubTaskRepository subTaskRepository = new SubTaskRepository();
                // Adding to list.
                List<SubTask> listSubTask = subTaskRepository.GetAll(Task.Id);
                // Showing information about Sub-tasks.
                if (listSubTask.Count > 0)
                {
                    Console.WriteLine($"\t\t\t▌  Project Id contains: {Task.Id}");
                    foreach (SubTask comment in listSubTask)
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

                    // Part of editing.
                    Console.WriteLine("\t\t\t▌  Which sub-task id do you want to edit?: ");
                    int inputId = IntegerValidation();
                    List<SubTask> comments = subTaskRepository.GetAll(inputId);
                    foreach (var task in comments)
                    {
                        Console.WriteLine($"\t\t\t▌  Title: {task.Title}");
                        Console.WriteLine("\t\t\t▌  New Title");
                        task.Title = WordValidator();
                        Console.WriteLine($"\t\t\t▌  Description: {task.Description}");
                        Console.WriteLine("\t\t\t▌  New Description ");
                        task.Description = WordValidator();
                        Console.WriteLine($"\t\t\t▌  Responsible: {task.ResponsibleId}");
                        Console.WriteLine("\t\t\t▌  New Responsible:");
                        UserRepository userRepository = new UserRepository();
                        List<Entities.User> users = userRepository.GetAll();
                        Console.Write("\t\t\t▌  ");
                        foreach (var user in users)
                        {
                            Console.Write(user.Username + " ");
                        }

                        Console.Write("\n");
                        string userInput = WordValidator();
                        foreach (var user in users.Where(user =>
                            userInput != null && userInput.Contains(user.Username)))
                        {
                            task.ResponsibleId = user.Username;
                        }

                        Console.WriteLine($"\t\t\t▌  Working Hours: {task.WorkingHours}");
                        Console.WriteLine("\t\t\t▌  New Working Hours: ");
                        task.WorkingHours = IntegerValidation();
                        task.LastEditDate = DateTime.Now;
                        Console.WriteLine($"\t\t\t▌  Current Priority: {task.TaskStatus}");
                        Console.WriteLine("\t\t\t▌  New Task Priority [1]Epic, [2]Task, [3]Bug, [4]Story: ");
                        string statusTask = Console.ReadLine() ?? string.Empty;

                        Console.WriteLine($"\t\t\t▌  Current Status: {task.Status}");
                        // Checking status.
                        Console.WriteLine("\t\t\t▌  Status InProgress - [1] or Finished - [2] or Opened [3]: ");
                        string input = Console.ReadLine() ?? string.Empty;
                        switch (input)
                        {
                            case "1":
                                task.Status = (SubTaskStatus) Enum.Parse(typeof(SubTaskStatus), "InProgress");
                                break;
                            case "2":
                                task.Status = (SubTaskStatus) Enum.Parse(typeof(SubTaskStatus), "Finished");
                                break;
                            case "3":
                                task.Status = (SubTaskStatus) Enum.Parse(typeof(SubTaskStatus), "Opened");
                                break;
                            default:
                                Console.WriteLine("\t\t\t▌  Auto-Selected Default");
                                task.Status = (SubTaskStatus) Enum.Parse(typeof(SubTaskStatus), "Opened");
                                break;
                        }

                        Console.WriteLine("\t\t\t▌  Sub-task changed!");
                        Console.ReadKey();
                        subTaskRepository.Add(task);

                    }
                }
                else
                {
                    Console.WriteLine("\t\t\t▌  You currently don't have any sub-tasks..");
                    Console.WriteLine("\t\t\t▌  Press any key to continue...");
                    Console.ReadKey();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
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
                Console.Write("\t\t\t▌  Type here:");
            } while (!int.TryParse(Console.ReadLine(), out entityId) || entityId <= 0);

            return entityId;
        }

        /// <summary>
        /// Add sub-task element.
        /// </summary>
        private void Add()
        {
            Console.Clear();

            try
            {
                // Getting info about the max-tasks.
                Console.WriteLine("\t\t\t▌  How many sub-tasks do you want to create: ");
                Task.CountTask = IntegerValidation();
                SubTaskRepository commentRepo = new SubTaskRepository();
                // Doing n-current tasks to add to repo.
                for (int i = 0; i < Task.CountTask; i++)
                {
                    // Creating new classes of repository.
                    SubTask subTask = new SubTask
                    {
                        IdCreator = Task.Id
                    };

                    UserRepository userRepository = new UserRepository();
                    List<Entities.User> users = userRepository.GetAll();

                    // Function of adding
                    int temp = i;
                    Console.WriteLine($"\t\t\t▌   {++temp} Task");
                    Console.WriteLine("\t\t\t▌  Title");
                    subTask.Title = WordValidator();
                    Console.Write("\t\t\t▌  Description");
                    subTask.Description = WordValidator();
                    bool correct = false;
                    do
                    {
                        Console.WriteLine("\t\t\t▌  Choose Responsible Username: ");
                        Console.Write("\t\t\t▌  ");
                        foreach (var user in users)
                        {
                            Console.Write(user.Username + " ");
                        }

                        Console.Write("\n");
                        subTask.CreatorId = WordValidator();
                        string[] names = subTask.CreatorId?.Split(' ');
                        foreach (var user in users)
                        {
                            for (int j = 0; j < names.Length; j++)
                            {
                                if (names[j].Contains(user.Username))
                                {
                                    correct = true;
                                    break;
                                }
                            }
                        }
                    } while (!correct);

                    Console.WriteLine("\t\t\t▌  Working Hours: ");
                    subTask.WorkingHours = IntegerValidation();
                    subTask.LastEditDate = DateTime.Now;
                    // Validating task priority status.
                    Console.WriteLine("\t\t\t▌  Task Priority [1]Task, [2]Bug, [3]Story: ");
                    int statusTask = IntegerValidation();
                    switch (statusTask)
                    {
                        case 1:
                            subTask.TaskStatus = (TaskStatusEnum)Enum.Parse(typeof(TaskStatusEnum), "Task");
                            break;
                        case 2:
                            subTask.TaskStatus = (TaskStatusEnum)Enum.Parse(typeof(TaskStatusEnum), "Bug");
                            break;
                        case 3:
                            subTask.TaskStatus = (TaskStatusEnum)Enum.Parse(typeof(TaskStatusEnum), "Story");
                            break;
                        default:
                            Console.WriteLine("\t\t\t▌  Auto-Selected Default");
                            subTask.TaskStatus = (TaskStatusEnum)Enum.Parse(typeof(TaskStatusEnum), "Task");
                            break;
                    }
                    // Validating status.
                    Console.WriteLine("\t\t\t▌  Status InProgress - [1] or Finished - [2] or Opened [3]: ");
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
                Console.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// Add sub-task element.
        /// </summary>
        private void EpicAdd()
        {
            Console.Clear();

            try
            {
                // Getting info about the max-tasks.
                Console.WriteLine("\t\t\t▌  How many sub-tasks for epic do you want to create: ");
                Task.CountTask = IntegerValidation();
                EpicRepository epicRepository = new EpicRepository();
                // Doing n-current tasks to add to repo.
                for (int i = 0; i < Task.CountTask; i++)
                {
                    // Creating new classes of repository.
                    EpicTask epicTask = new EpicTask
                    {
                        IdCreator = Task.Id
                    };

                    UserRepository userRepository = new UserRepository();
                    List<Entities.User> users = userRepository.GetAll();

                    // Function of adding
                    int temp = i;
                    Console.WriteLine($"\t\t\t▌   {++temp} Task");
                    Console.WriteLine("\t\t\t▌  Title");
                    epicTask.Title = WordValidator();
                    Console.WriteLine("\t\t\t▌  Description: ");
                    epicTask.Description = WordValidator();
                    bool correct = false;
                    do
                    {
                        Console.WriteLine("\t\t\t▌  Choose Responsible Username: ");
                        Console.Write("\t\t\t▌  ");
                        foreach (var user in users)
                        {
                            Console.Write(user.Username + " ");
                        }

                        Console.Write("\n");
                        epicTask.CreatorId = WordValidator();
                        string[] names = epicTask.CreatorId?.Split(' ');
                        foreach (var user in users)
                        {
                            for (int j = 0; j < names.Length; j++)
                            {
                                if (names[j].Contains(user.Username))
                                {
                                    correct = true;
                                    break;
                                }
                            }
                        }
                    } while (!correct);

                    Console.WriteLine("\t\t\t▌  Working Hours: ");
                    epicTask.WorkingHours = IntegerValidation();
                    epicTask.LastEditDate = DateTime.Now;
                    // Validating task priority status.
                    Console.WriteLine("\t\t\t▌  Task Priority [1]Task, [2]Story: ");
                    int statusTask = IntegerValidation();
                    switch (statusTask)
                    {
                        case 1:
                            epicTask.Priority = (EpicTaskPriority)Enum.Parse(typeof(EpicTaskPriority), "Task");
                            break;
                        case 2:
                            epicTask.Priority = (EpicTaskPriority)Enum.Parse(typeof(EpicTaskPriority), "Story");
                            break;
                        default:
                            Console.WriteLine("\t\t\t▌  Auto-Selected Default");
                            epicTask.Priority = (EpicTaskPriority)Enum.Parse(typeof(EpicTaskPriority), "Task");
                            break;
                    }
                    // Validating status.
                    Console.WriteLine("\t\t\t▌  Status InProgress - [1], Finished - [2], Opened [3]: ");
                    int input = IntegerValidation();
                    switch (input)
                    {
                        case 1:
                            epicTask.Status = (EpicTaskStatus)Enum.Parse(typeof(EpicTaskStatus), "InProgress");
                            break;
                        case 2:
                            epicTask.Status = (EpicTaskStatus)Enum.Parse(typeof(EpicTaskStatus), "Finished");
                            break;
                        case 3:
                            epicTask.Status = (EpicTaskStatus)Enum.Parse(typeof(EpicTaskStatus), "Opened");
                            break;
                        default:
                            Console.WriteLine("\t\t\t▌  Auto-Selected Default");
                            epicTask.Status = (EpicTaskStatus)Enum.Parse(typeof(EpicTaskStatus), "Opened");
                            break;
                    }
                    Console.WriteLine("\t\t\t▌  Epic Sub-task created!");
                    Console.ReadKey();
                    epicRepository.Add(epicTask);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}