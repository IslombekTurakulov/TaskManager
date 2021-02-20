using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using ManagerLib.Entities;

namespace ManagerWF
{
    public abstract class MainFormRepository<T> where T : BaseEntity
    {
        public virtual string FilePath { get; set; }

        public virtual List<T> GetAll()
        {
            List<T> entities = new List<T>();

            try
            {
                using FileStream fs = new FileStream(FilePath, FileMode.OpenOrCreate);
                using StreamReader sr = new StreamReader(fs);
                while (!sr.EndOfStream)
                {
                    T entity = GetEntity(sr);
                    entities.Add(entity);
                }

                return entities;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;
        }

        public virtual T GetById(int id)
        {
            try
            {
                using FileStream fs = new FileStream(FilePath, FileMode.OpenOrCreate);
                using StreamReader sr = new StreamReader(fs);
                while (!sr.EndOfStream)
                {
                    T entity = GetEntity(sr);

                    if (entity.Id.Equals(id))
                    {
                        return entity;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return null;
        }

        public int GetNextId()
        {
            int id = 0;
            try
            {
                using FileStream fs = new FileStream(FilePath, FileMode.OpenOrCreate);
                using StreamReader sr = new StreamReader(fs);
                while (!sr.EndOfStream)
                {
                    T entity = GetEntity(sr);

                    id = (id < entity.Id) switch
                    {
                        true => entity.Id,
                        _ => id
                    };
                }

                id++;
                return id;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return 0;
        }

        public void Add(T item)
        {
            item.Id = GetNextId();
            try
            {
                using FileStream fs = new FileStream(FilePath, FileMode.Append);
                using StreamWriter sw = new StreamWriter(fs);
                SaveEntity(item, sw);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void Edit(T item)
        {
            try
            {
                string tempFile = $"temp.{FilePath}";

                using (FileStream ifs = new FileStream(FilePath, FileMode.OpenOrCreate))
                using (StreamReader sr = new StreamReader(ifs))
                using (FileStream ofs = new FileStream(tempFile, FileMode.OpenOrCreate))
                using (StreamWriter sw = new StreamWriter(ofs))
                {
                    while (!sr.EndOfStream)
                    {
                        T entity = GetEntity(sr);

                        SaveEntity(item.Id == entity.Id ? item : entity, sw);
                    }
                }

                File.Delete(FilePath);
                File.Move(tempFile, FilePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void Delete(T item)
        {
            try
            {
                string tempFile = $"temp.{FilePath}";

                using (FileStream ifs = new FileStream(FilePath, FileMode.OpenOrCreate))
                using (StreamReader sr = new StreamReader(ifs))
                using (FileStream ofs = new FileStream(tempFile, FileMode.OpenOrCreate))
                using (StreamWriter sw = new StreamWriter(ofs))
                {
                    while (!sr.EndOfStream)
                    {
                        T entity = GetEntity(sr);

                        if (item.Id != entity.Id)
                        {
                            SaveEntity(entity, sw);
                        }
                    }
                }

                File.Delete(FilePath);
                File.Move(tempFile, FilePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

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

        protected abstract void SaveEntity(T entity, StreamWriter sw);

        protected abstract T GetEntity(StreamReader sr);
    }
}
