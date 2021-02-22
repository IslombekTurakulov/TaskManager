using System;
using System.Collections.Generic;
using System.IO;
using ManagerLib.Entities;

namespace ManagerLib.Repositories
{
    public abstract class BaseRepository<T> where T : BaseEntity
    {
        public virtual string FilePath { get; set; }

        /// <summary>
        /// Getting all data.
        /// </summary>
        /// <returns></returns>
        public virtual List<T> GetAll()
        {
            List<T> entities = new List<T>();

            try
            {
                // Introducing Stream to get information.
                using FileStream fs = new FileStream(FilePath, FileMode.OpenOrCreate);
                using StreamReader sr = new StreamReader(fs);
                while (!sr.EndOfStream)
                {
                    T entity = GetEntity(sr);
                    entities.Add(entity);
                }
                
                return entities;
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return null;
        }

        /// <summary>
        /// Getting entity id
        /// </summary>
        /// <param name="id">entity ID</param>
        /// <returns>Any object (Task, Comment, Record, SubTask, User)</returns>
        public virtual T GetById(int id)
        {
            try
            {
                // Intializing Stream to read the filepath.
                using FileStream fs = new FileStream(FilePath, FileMode.OpenOrCreate);
                using StreamReader sr = new StreamReader(fs);
                while (!sr.EndOfStream)
                {
                    // Getting entity element and checking of equality.
                    T entity = GetEntity(sr);

                    if (entity.Id.Equals(id))
                    {
                        return entity;
                    }
                }
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return null;
        }

        /// <summary>
        /// Getting Next id.
        /// </summary>
        /// <returns></returns>
        public int GetNextId()
        {
            int id = 0;
            try
            {
                // Intializing Stream to read the filepath.
                using FileStream fs = new FileStream(FilePath, FileMode.OpenOrCreate);
                using StreamReader sr = new StreamReader(fs);
                while (!sr.EndOfStream)
                {
                    T entity = GetEntity(sr);

                    // Checking if id is less than entity
                    // It means that we need to return the first.
                    id = (id < entity.Id) switch
                    {
                        true => entity.Id,
                        _ => id
                    };
                }

                id++;
                return id;
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return 0;
        }

        /// <summary>
        /// Adding entity.
        /// </summary>
        /// <param name="item">Any object (Task, Comment, Record, SubTask, User)</param>
        public void Add(T item)
        {
            item.Id = GetNextId();
            try
            {
                // Initializing Stream to append the edited data.
                using FileStream fs = new FileStream(FilePath, FileMode.Append);
                using StreamWriter sw = new StreamWriter(fs);
                // Method , which saves all data to selected path.
                SaveEntity(item, sw);
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// Edit entity.
        /// </summary>
        /// <param name="item"></param>
        public void Edit(T item)
        {
            try
            {
                string tempFile = $"temp.{FilePath}";

                // Initializing Stream to append the edited data.
                using (FileStream ifs = new FileStream(FilePath, FileMode.OpenOrCreate))
                using (StreamReader sr = new StreamReader(ifs))
                using (FileStream ofs = new FileStream(tempFile, FileMode.OpenOrCreate))
                using (StreamWriter sw = new StreamWriter(ofs))
                {
                    while (!sr.EndOfStream)
                    {
                        // Getting entity and saving it.
                        T entity = GetEntity(sr);

                        SaveEntity(item.Id == entity.Id ? item : entity, sw);
                    }
                }

                File.Delete(FilePath);
                File.Move(tempFile, FilePath);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// Delete entity.
        /// </summary>
        /// <param name="item"></param>
        public void Delete(T item)
        {
            try
            {
                // It's required to created temp file for consequence situations.
                string tempFile = $"temp.{FilePath}";

                // Initializing Stream to append the edited data.
                using (FileStream ifs = new FileStream(FilePath, FileMode.OpenOrCreate))
                using (StreamReader sr = new StreamReader(ifs))
                using (FileStream ofs = new FileStream(tempFile, FileMode.OpenOrCreate))
                using (StreamWriter sw = new StreamWriter(ofs))
                {
                    while (!sr.EndOfStream)
                    {
                        // Getting entity and expressing the new and old.
                        T entity = GetEntity(sr);

                        if (item.Id != entity.Id)
                        {
                            SaveEntity(entity, sw);
                        }
                    }
                }
                // Deleting selected filepath
                File.Delete(FilePath);
                // Creating the new file with information of the previous path.
                File.Move(tempFile, FilePath);
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// Save entity.
        /// </summary>
        /// <param name="entity">Any object (Task, Comment, Record, SubTask, User)</param>
        public void Save(T entity)
        {
            switch (entity.Id)
            {
                case 0:
                    Add(entity);
                    break;
                default:
                    Edit(entity);
                    break;
            }
        }

        //Abstract Methods

        /// <summary>
        /// Saving data.
        /// </summary>
        /// <param name="entity">Any object (Task, Comment, Record, SubTask, User)</param>
        /// <param name="sw">Requires StreamWriter</param>
        protected abstract void SaveEntity(T entity, StreamWriter sw);

        /// <summary>
        /// Getting info or data on object.
        /// </summary>
        /// <param name="sr">Requires StreamReader</param>
        /// <returns>Any object (Task, Comment, Record, SubTask, User)</returns>
        protected abstract T GetEntity(StreamReader sr);
    }
}
