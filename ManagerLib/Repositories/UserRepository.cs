using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using ManagerLib.Entities;
using Newtonsoft.Json;

namespace ManagerLib.Repositories
{
    public class UserRepository : BaseRepository<Entities.User>
    {
        public override string FilePath => base.FilePath = "users.txt";

        protected override Entities.User GetEntity(StreamReader sr)
        {
            try
            {
                Entities.User user = new Entities.User
                {
                    Id = int.Parse(sr.ReadLine() ?? string.Empty),
                    Username = sr.ReadLine(),
                    IsAdmin = Convert.ToBoolean(sr.ReadLine())
                };
                return user;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return null;
        }

        protected override void SaveEntity(Entities.User user, StreamWriter sw)
        {
            sw.WriteLine(user.Id);
            sw.WriteLine(user.Username);
            sw.WriteLine(user.IsAdmin);
        }

        public Entities.User GetByUsername(string username)
        {
            try
            {
                using FileStream fs = new FileStream(FilePath, FileMode.OpenOrCreate);
                using StreamReader sr = new StreamReader(fs);
                while (!sr.EndOfStream)
                {
                    Entities.User user = GetEntity(sr);

                    if (username != user.Username) continue;
                    return user;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return null;
        }
    }
}