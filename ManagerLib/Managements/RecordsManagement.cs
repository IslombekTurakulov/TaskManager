using System;
using System.Collections.Generic;
using ManagerLib.Entities;
using ManagerLib.Repositories;
using ManagerLib.User;

namespace ManagerLib.Managements
{
    public class RecordsManagement
    {
        public Task Task;

        public RecordsManagement(Task task)
        {
            Task = task;
        }

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

            RecordRepository recordRepo = new RecordRepository();
            List<Record> records = recordRepo.GetAll(Task.Id);
            if (records.Count > 0)
            {
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
            int current = Task.Id;
            Record record = new Record
                { TaskId =current, UserId = LoginValidation.LoggedUser.Id, CreateDate = DateTime.Now };

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