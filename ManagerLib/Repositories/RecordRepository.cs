using System;
using System.Collections.Generic;
using System.IO;
using ManagerLib.Entities;

#pragma warning disable

namespace ManagerLib.Repositories
{
    internal class RecordRepository : BaseRepository<Record>
    {
        public override string FilePath => base.FilePath = "records.txt";

        /// <summary>
        /// Getting data from FilePath.
        /// </summary>
        /// <param name="sr">Requires StreamReader</param>
        /// <returns>Record</returns>
        protected override Record GetEntity(StreamReader sr)
        {
            try
            {
                Record record = new Record
                {
                    Id = int.Parse(sr.ReadLine() ?? string.Empty),
                    TaskId = int.Parse(sr.ReadLine() ?? string.Empty),
                    UserId = int.Parse(sr.ReadLine() ?? string.Empty),
                    WorkingHours = int.Parse(sr.ReadLine() ?? string.Empty),
                    CreateDate = DateTime.Parse(sr.ReadLine() ?? string.Empty)
                };
                return record;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        /// <summary>
        /// Saving entity.
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="sw"></param>
        protected override void SaveEntity(Record entity, StreamWriter sw)
        {
            try
            {
                sw.WriteLine(entity.Id);
                sw.WriteLine(entity.TaskId);
                sw.WriteLine(entity.UserId);
                sw.WriteLine(entity.WorkingHours);
                sw.WriteLine(entity.CreateDate);
            }
            catch (Exception ex)
            {
                // ignored
            }
        }

        /// <summary>
        /// GetAll data from FilePath
        /// </summary>
        /// <param name="taskId">current object Task.Id</param>
        /// <returns></returns>
        public List<Record> GetAll(int taskId)
        {
            try
            {
                List<Record> records = new List<Record>();

                using FileStream fs = new FileStream(FilePath, FileMode.OpenOrCreate);
                using StreamReader sr = new StreamReader(fs);
                while (!sr.EndOfStream)
                {
                    Record record = GetEntity(sr);

                    if (record.TaskId == taskId) records.Add(record);
                }

                return records;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}