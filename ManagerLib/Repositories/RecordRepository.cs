using System;
using System.Collections.Generic;
using System.IO;
using ManagerLib.Entities;
using Newtonsoft.Json;
#pragma warning disable

namespace ManagerLib.Repositories
{
    internal class RecordRepository : BaseRepository<Record>
    {
        public override string FilePath
        {
            get
            {
                return base.FilePath = "records.txt";
            }
        }

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
            }
        }

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

                    if (record.TaskId == taskId)
                    {
                        records.Add(record);
                    }
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