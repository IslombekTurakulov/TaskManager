using System;
using System.Collections.Generic;
using System.IO;
using ManagerLib.Entities;

#pragma warning disable

namespace ManagerLib.Repositories
{
    internal class EpicRepository : BaseRepository<EpicTask>
    {
        public override string FilePath => base.FilePath = "epicTasks.txt";

        /// <summary>
        /// Getting data from FilePath.
        /// </summary>
        /// <param name="sr">Requires StreamReader</param>
        /// <returns>SubTask</returns>
        protected override EpicTask GetEntity(StreamReader sr)
        {
            try
            {
                EpicTask task = new EpicTask
                {
                    Id = int.Parse(sr.ReadLine() ?? string.Empty),
                    Title = sr.ReadLine(),
                    Description = sr.ReadLine(),
                    WorkingHours = int.Parse(sr.ReadLine() ?? string.Empty),
                    CreatorId = sr.ReadLine() ?? string.Empty,
                    IdCreator = int.Parse(sr.ReadLine() ?? string.Empty),
                    LastEditDate = DateTime.Parse(sr.ReadLine() ?? string.Empty),
                    Status = (EpicTaskStatus)Enum.Parse(typeof(EpicTaskStatus), sr.ReadLine() ?? string.Empty),
                    Priority = (EpicTaskPriority)Enum.Parse(typeof(EpicTaskPriority), sr.ReadLine() ?? string.Empty),
                };

                return task;
            }
            catch (Exception ex)
            {
            }
            return null;
        }

        /// <summary>
        /// Saving entity.
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="sw"></param>
        protected override void SaveEntity(EpicTask entity, StreamWriter sw)
        {
            sw.WriteLine(entity.Id);
            sw.WriteLine(entity.Title);
            sw.WriteLine(entity.Description);
            sw.WriteLine(entity.WorkingHours);
            sw.WriteLine(entity.CreatorId);
            sw.WriteLine(entity.IdCreator);
            sw.WriteLine(entity.LastEditDate);
            sw.WriteLine(entity.Status);
            sw.WriteLine(entity.Priority);
        }

        public List<EpicTask> GetAll(int taskId)
        {
            try
            {
                List<EpicTask> tasks = new List<EpicTask>();

                using FileStream fs = new FileStream(FilePath, FileMode.OpenOrCreate);
                using StreamReader sr = new StreamReader(fs);
                while (!sr.EndOfStream)
                {
                    EpicTask task = GetEntity(sr);

                    if (task.IdCreator == taskId)
                    {
                        tasks.Add(task);
                    }
                }

                return tasks;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return null;
        }
    }
}