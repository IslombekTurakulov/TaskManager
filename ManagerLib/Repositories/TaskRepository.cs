using System;
using System.Collections.Generic;
using System.IO;
using ManagerLib.Entities;
using ManagerLib.User;

namespace ManagerLib.Repositories
{
    public class TaskRepository : BaseRepository<Task>
    {
        public override string FilePath => base.FilePath = "tasks.txt";

        /// <summary>
        /// Getting data from FilePath.
        /// </summary>
        /// <param name="sr">Requires StreamReader</param>
        /// <returns>Task</returns>
        protected override Task GetEntity(StreamReader sr)
        {
            try
            {
                Task task = new Task
                {
                    Id = int.Parse(sr.ReadLine() ?? string.Empty),
                    Title = sr.ReadLine(),
                    Description = sr.ReadLine(),
                    WorkingHours = int.Parse(sr.ReadLine() ?? string.Empty),
                    CreatorId = int.Parse(sr.ReadLine() ?? string.Empty),
                    ResponsibleId = sr.ReadLine() ?? string.Empty,
                    CreateDate = DateTime.Parse(sr.ReadLine() ?? string.Empty),
                    LastEditDate = DateTime.Parse(sr.ReadLine() ?? string.Empty),
                    Status = (StatusEnum)Enum.Parse(typeof(StatusEnum), sr.ReadLine() ?? string.Empty)
                };
                return task;
            }
        
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return null;
        }

        /// <summary>
        /// Saving entity.
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="sw"></param>
        protected override void SaveEntity(Task entity, StreamWriter sw)
        {
            sw.WriteLine(entity.Id);
            sw.WriteLine(entity.Title);
            sw.WriteLine(entity.Description);
            sw.WriteLine(entity.WorkingHours);
            sw.WriteLine(entity.CreatorId);
            sw.WriteLine(entity.ResponsibleId);
            sw.WriteLine(entity.CreateDate);
            sw.WriteLine(entity.LastEditDate);
            sw.WriteLine(entity.Status);
        }

        /// <summary>
        /// GetAll data from FilePath
        /// </summary>
        /// <param name="taskId">current object Task.Id</param>
        /// <returns></returns>
        public override List<Task> GetAll()
        {
            List<Task> tasks = new List<Task>();

            using FileStream fs = new FileStream(FilePath, FileMode.OpenOrCreate);
            using StreamReader sr = new StreamReader(fs);
            while (!sr.EndOfStream)
            {
                Task task = GetEntity(sr);

                if (task.CreatorId.Equals(LoginValidation.LoggedUser.Id))
                {
                    tasks.Add(task);
                }
            }

            return tasks;
        }

        /// <summary>
        /// GetById data from FilePath
        /// </summary>
        /// <param name="id">current object ID</param>
        /// <returns></returns>
        public override Task GetById(int id)
        {
            using FileStream fs = new FileStream(FilePath, FileMode.OpenOrCreate);
            using StreamReader sr = new StreamReader(fs);
            while (!sr.EndOfStream)
            {
                Task task = GetEntity(sr);

                if (task.Id.Equals(id))
                    return task;
            }

            return null;
        }
    }
}