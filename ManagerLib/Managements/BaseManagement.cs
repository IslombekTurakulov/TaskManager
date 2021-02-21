using System;
using System.Collections.Generic;
using ManagerLib.Entities;
using ManagerLib.Repositories;
using ManagerLib.User;


namespace ManagerLib.Managements
{

    public abstract class BaseManagement<T> where T : BaseEntity, new()
    {
        public virtual T Entity { get; set; }

        public void Show()
        {
            bool isExit = true;
            while (isExit)
            {
                AdminMenu choice = RenderMenu();

                switch (choice)
                {
                    case AdminMenu.List:
                        List();
                        Console.ReadKey();
                        break;
                    case AdminMenu.View:
                        View();
                        break;
                    case AdminMenu.Add:
                        Add();
                        break;
                    case AdminMenu.Edit:
                        Edit();
                        break;
                    case AdminMenu.Delete:
                        Delete();
                        break;
                    case AdminMenu.Back:
                        isExit = false;
                        break;
                    case AdminMenu.Exit:
                        return;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
            }
        }

        protected void List()
        {
            Console.Clear();

            try
            {
             
                BaseRepository<T> entityRepo = GetRepo();

                List<T> entities = entityRepo.GetAll();

                if (entities.Count > 0)
                {
                    foreach (T entity in entities)
                    {
                        RenderEntity(entity);
                    }
                }
                else
                {
                    Console.WriteLine("\t\t\t▌  Currently there's empty");
                    Console.WriteLine("\t\t\t▌  Press any key to continue..");
                    Console.ReadKey();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        protected virtual void View()
        {
            try
            {
                BaseRepository<T> entityRepo = GetRepo();
                List<T> list = entityRepo.GetAll();
                if (list.Count > 0)
                {
                    while (true)
                    {
                        List();
                        int entityId;

                        do
                        {
                            Console.Clear();
                            List();
                            Console.WriteLine("\t\t\t▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬");
                            Console.Write($"\t\t\t▌  {typeof(T).Name} ID: ");
                        } while (!int.TryParse(Console.ReadLine(), out entityId) || entityId < 0);

                        T entity = entityRepo.GetById(entityId);

                        if (entity != null)
                        {
                            RenderEntity(entity);
                            Entity = entity;
                            break;
                        }
                        Console.WriteLine($"\t\t\t▌  {typeof(T).Name} not found!");
                    }
                }
                else
                {
                    Console.WriteLine("\t\t\t▌  Currently there's empty");
                    Console.WriteLine("\t\t\t▌  Press any key to continue..");
                    Console.ReadKey();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        protected void Add()
        {
            Console.Clear();

            T entity = new T();
            Console.WriteLine("\t\t\t▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬");
            Console.WriteLine($"\t\t\t▌  Add new {typeof(T).Name}");

            entity = GetEntity(entity);

            BaseRepository<T> entityRepo = GetRepo();
            entityRepo.Save(entity);

            Console.WriteLine($"\t\t\t▌  {typeof(T).Name} successfully added!");
            Console.ReadKey();
        }

        protected void Edit()
        {
            try
            {
                BaseRepository<T> entityRepo = GetRepo();
                List<T> list = entityRepo.GetAll();
                if (list.Count > 0)
                {
                    while (true)
                    {
                        int entityId;
                        do
                        {
                            Console.Clear();
                            List();
                            Console.Write($"\t\t\t▌  {typeof(T).Name} ID: ");
                        } while (!int.TryParse(Console.ReadLine(), out entityId) || entityId < 0);

                        T entity = entityRepo.GetById(entityId);

                        if (entity == null)
                        {
                            Console.WriteLine($"\t\t\t▌  {typeof(T).Name} not found!");
                        }

                        else
                        {
                            entity = EditEntity(entity);
                            entityRepo.Save(entity);
                            Console.WriteLine($"\t\t\t▌  {typeof(T).Name} successfully edited!");
                            break;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("\t\t\t▌  Currently there's empty");
                    Console.WriteLine("\t\t\t▌  Press any key to continue..");
                }
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        protected void Delete()
        {
            Console.Clear();
            try
            {
                BaseRepository<T> entityRepo = GetRepo();
                int entityId;
                List<T> list = entityRepo.GetAll();
                if (list.Count > 0)
                {
                    do
                    {
                        Console.Clear();
                        List();
                        Console.Write($"\t\t\t▌ Delete {typeof(T).Name} ID: ");
                    } while (!int.TryParse(Console.ReadLine(), out entityId) || entityId < 0);

                    T entity = entityRepo.GetById(entityId);

                    switch (entity)
                    {
                        case null:
                            Console.WriteLine($"\t\t\t▌  {typeof(T).Name} not found!");
                            break;
                        default:
                            entityRepo.Delete(entity);
                            Console.WriteLine($"\t\t\t▌  {typeof(T).Name} successfully deleted!");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("\t\t\t▌  Currently there's empty");
                    Console.WriteLine("\t\t\t▌  Press any key to continue..");
                }
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public AdminMenu RenderMenu()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("\t\t\t▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬");
                Console.WriteLine($"\t\t\t▌   {typeof(T).Name} Management");
                Console.WriteLine("\t\t\t▌  [L]ist all:");
                Console.WriteLine("\t\t\t▌  [V]iew:");
                Console.WriteLine("\t\t\t▌  [A]dd:");
                Console.WriteLine("\t\t\t▌  [E]dit:");
                Console.WriteLine("\t\t\t▌  [D]elete:");
                Console.WriteLine("\t\t\t▌  [B]ack");
                Console.WriteLine("\t\t\t▌  E[x]it:");
                Console.Write("\t\t\t▌  Type here: ");
                string choice = Console.ReadLine();
                switch (choice?.ToUpper())
                {
                    case "L":
                        return AdminMenu.List;
                    case "V":
                        return AdminMenu.View;
                    case "A":
                        return AdminMenu.Add;
                    case "E":
                        return AdminMenu.Edit;
                    case "D":
                        return AdminMenu.Delete;
                    case "B":
                        return AdminMenu.Back;
                    case "X":
                        return AdminMenu.Exit;
                    default:
                        Console.WriteLine("\t\t\t▌  Invalid operation!");
                        Console.ReadKey();
                        break;
                }
                Console.WriteLine("\t\t\t▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬");
            }
        }

        protected abstract BaseRepository<T> GetRepo();

        protected abstract void RenderEntity(T entity);

        protected abstract T GetEntity(T entity);

        protected abstract T EditEntity(T entity);
    }

}
