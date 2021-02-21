using System;
using System.Collections.Generic;
using System.IO;
using ManagerLib.Entities;

#pragma warning disable

namespace ManagerLib.Repositories
{
    internal class SubTaskRepository : BaseRepository<SubTask>
    {
        public override string FilePath => base.FilePath = "subTasks.txt";


        protected override SubTask GetEntity(StreamReader sr)
        {
            try
            {
                SubTask task = new SubTask
                {
                    Id = int.Parse(sr.ReadLine() ?? string.Empty),
                    SubTaskId = int.Parse(sr.ReadLine() ?? string.Empty),
                    Title = sr.ReadLine(),
                    Description = sr.ReadLine(),
                    WorkingHours = int.Parse(sr.ReadLine() ?? string.Empty),
                    CreatorId = sr.ReadLine() ?? string.Empty,
                    LastEditDate = DateTime.Parse(sr.ReadLine()),
                    Status = (SubTaskStatus)Enum.Parse(typeof(SubTaskStatus), sr.ReadLine() ?? string.Empty),
                    TaskStatus = (TaskStatusEnum)Enum.Parse(typeof(TaskStatusEnum), sr.ReadLine() ?? string.Empty),
                };
                return task;
            }
            catch (Exception ex)
            {
            }
            return null;
        }

        protected override void SaveEntity(SubTask entity, StreamWriter sw)
        {
            sw.WriteLine(entity.Id);
            sw.WriteLine(entity.SubTaskId);
            sw.WriteLine(entity.Title);
            sw.WriteLine(entity.Description);
            sw.WriteLine(entity.WorkingHours);
            sw.WriteLine(entity.CreatorId);
            sw.WriteLine(entity.LastEditDate);
            sw.WriteLine(entity.Status);
            sw.WriteLine(entity.TaskStatus);
        }

        public List<SubTask> GetAll(int taskId)
        {
            try
            {
                List<SubTask> tasks = new List<SubTask>();

                using FileStream fs = new FileStream(FilePath, FileMode.OpenOrCreate);
                using StreamReader sr = new StreamReader(fs);
                while (!sr.EndOfStream)
                {
                    SubTask task = GetEntity(sr);

                    if (task.SubTaskId == taskId)
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