using System;
using System.Collections.Generic;
using System.IO;
using ManagerLib.Entities;

namespace ManagerLib.Repositories
{
    internal class CommentRepository : BaseRepository<Comment>
    {
        public override string FilePath => base.FilePath = "comments.txt";

       
        protected override Comment GetEntity(StreamReader sr)
        {
            try
            {
                Comment comment = new Comment
                {
                    Id = int.Parse(sr.ReadLine() ?? string.Empty),
                    TaskId = int.Parse(sr.ReadLine() ?? string.Empty),
                    UserId = int.Parse(sr.ReadLine() ?? string.Empty),
                    Text = sr.ReadLine(),
                    CreateDate = DateTime.Parse(sr.ReadLine() ?? string.Empty)
                };
                return comment;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return null;
        }

        protected override void SaveEntity(Comment entity, StreamWriter sw)
        {
            sw.WriteLine(entity.Id);
            sw.WriteLine(entity.TaskId);
            sw.WriteLine(entity.UserId);
            sw.WriteLine(entity.Text);
            sw.WriteLine(entity.CreateDate);
        }

        public List<Comment> GetAll(int taskId)
        {
            try
            {
                List<Comment> comments = new List<Comment>();

                using FileStream fs = new FileStream(FilePath, FileMode.OpenOrCreate);
                using StreamReader sr = new StreamReader(fs);
                while (!sr.EndOfStream)
                {
                    Comment comment = GetEntity(sr);

                    if (comment.TaskId.Equals(taskId))
                    {
                        comments.Add(comment);
                    }
                }

                return comments;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return null;
        }
    }
}