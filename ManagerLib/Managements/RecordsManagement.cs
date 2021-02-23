using System;
using ManagerLib.Entities;
using ManagerLib.Repositories;
using ManagerLib.User;

namespace ManagerLib.Managements
{
    public class RecordsManagement
    {
        // Fields.
        public Task Task;

        public RecordsManagement(Task task) => Task = task;

        /// <summary>
        /// Show menu Records.
        /// </summary>
        public void Show()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("\t\t\t▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬");
                Console.WriteLine("\t\t\t▌         Records");
                Console.WriteLine("\t\t\t▌  [L]ist all records");
                Console.WriteLine("\t\t\t▌  [A]dd record");
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
                if (choice == "B")
                {
                    // Back to last menu.
                    AdminView adminView = new AdminView();
                    adminView.Show();
                    break;
                }
                Console.WriteLine("\t\t\t▌  Invalid choice!");
            }
        }

        private void List()
        {
            Console.Clear();

            // Creating a new class of repository.
            var recordRepo = new RecordRepository();
            // Adding elements to list.
            var records = recordRepo.GetAll(Task.Id);
            if (records.Count > 0)
            {
                // Showing information about data records.
                foreach (Record record in records)
                {
                    Console.WriteLine($"\t\t\t▌  Working Hours: {record.WorkingHours}");
                    Console.WriteLine($"\t\t\t▌  Created Date: {record.CreateDate}");
                }
            }
            else
            {
                Console.WriteLine("\t\t\t▌  Records are empty...");
                Console.WriteLine("\t\t\t▌  Press any key to continue..");
            }

            Console.ReadKey();
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
            } while (!int.TryParse(Console.ReadLine(), out entityId) || entityId <= 0);

            return entityId;
        }

        /// <summary>
        /// Adding variable.
        /// </summary>
        private void Add()
        {
            Console.Clear();
            // Creating new Record object.
            Record record = new Record
            {
                TaskId = Task.Id,
                UserId = LoginValidation.LoggedUser.Id, 
                CreateDate = DateTime.Now
            };

            // Adding information.
            Console.WriteLine("\t\t\t▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬");
            Console.Write("\t\t\t▌  Working Hours: ");
            record.WorkingHours = IntegerValidation();
            RecordRepository recordRepo = new RecordRepository();
            recordRepo.Add(record);

            Console.WriteLine("\t\t\t▌  Record successfully added!");
            Console.WriteLine("\t\t\t▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬");
            Console.ReadKey();
        }
    }
}