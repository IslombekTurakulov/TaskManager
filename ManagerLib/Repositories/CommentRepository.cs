using System;
using System.Collections.Generic;
using System.IO;
using ManagerLib.Entities;

namespace ManagerLib.Repositories
{
    internal class CommentRepository : BaseRepository<Comment>
    {
        public override string FilePath => base.FilePath = "comments.txt";

       /// <summary>
       /// Getting data from FilePath.
       /// </summary>
       /// <param name="sr">Requires StreamReader</param>
       /// <returns>Comment</returns>
        protected override Comment GetEntity(StreamReader sr)
        {
            try
            {
                // Creating new object to return.
                var comment = new Comment
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

       /// <summary>
       /// Saving entity.
       /// </summary>
       /// <param name="entity"></param>
       /// <param name="sw"></param>
        protected override void SaveEntity(Comment entity, StreamWriter sw)
        {
            sw.WriteLine(entity.Id);
            sw.WriteLine(entity.TaskId);
            sw.WriteLine(entity.UserId);
            sw.WriteLine(entity.Text);
            sw.WriteLine(entity.CreateDate);
        }

       /// <summary>
       /// GetAll data from FilePath
       /// </summary>
       /// <param name="taskId">current object Task.Id</param>
       /// <returns></returns>
        public List<Comment> GetAll(int taskId)
        {
            try
            {
                List<Comment> comments = new List<Comment>();
                // Initialzing Stream to open file.
                using FileStream fs = new FileStream(FilePath, FileMode.OpenOrCreate);
                using StreamReader sr = new StreamReader(fs);
                while (!sr.EndOfStream)
                {
                    // Introducing variable to check the equality.
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