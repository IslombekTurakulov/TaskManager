using System;
using System.IO;

namespace ManagerLib.Repositories
{
    public class UserRepository : BaseRepository<Entities.User>
    {
        public override string FilePath => base.FilePath = "users.txt";


        /// <summary>
        /// Getting data from FilePath.
        /// </summary>
        /// <param name="sr">Requires StreamReader</param>
        /// <returns>User</returns>
        protected override Entities.User GetEntity(StreamReader sr)
        {
            try
            {
                var user = new Entities.User
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

        /// <summary>
        /// Saving entity.
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="sw"></param>
        protected override void SaveEntity(Entities.User user, StreamWriter sw)
        {
            sw.WriteLine(user.Id);
            sw.WriteLine(user.Username);
            sw.WriteLine(user.IsAdmin);
        }

        /// <summary>
        /// GetByUsername data from FilePath
        /// </summary>
        /// <param name="username">current object username</param>
        /// <returns></returns>
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