using System;
using System.Collections.Generic;
using ManagerLib.Entities;
using ManagerLib.Repositories;
using ManagerLib.User;
using static System.String;


namespace ManagerLib.Managements
{
    public class CommentsManagement
    {
        public Task Task;

        public CommentsManagement(Task task)
        {
            Task = task;
        }

        public void Show()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("\t\t\t▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬");
                Console.WriteLine("\t\t\t▌     Comments");
                Console.WriteLine("\t\t\t▌  [L]ist comments:");
                Console.WriteLine("\t\t\t▌  [A]dd comment:");
                Console.WriteLine("\t\t\t▌  [E]dit:");
                Console.WriteLine("\t\t\t▌  [B]ack");
                Console.Write("\t\t\t▌  Type here:");
                string choice = Console.ReadLine()?.ToUpper();
                if (choice == "L")
                {
                    List();
                    break;
                }

                if (choice == "A")
                {
                    Add();
                    break;
                }
                if (choice == "E")
                {
                    EditEntity();
                    break;
                }
                if (choice == "B")
                {
                    AdminView adminView = new AdminView();
                    adminView.Show();
                    adminView.Choice();
                    break;
                }
                Console.WriteLine("\t\t\t▌  Invalid choice!");
            }
        }

        protected void EditEntity()
        {
            CommentRepository commentRepo = new CommentRepository();
            List<Comment> comments = commentRepo.GetAll(Task.Id);
            if (comments.Count > 0)
            {
                foreach (var comment in comments)
                {
                    Console.WriteLine($"\t\t\t▌  Text: {comment.Text}");
                    Console.Write("\t\t\t▌  New Text: ");
                    comment.Text = Console.ReadLine() ?? Empty;
                    comment.CreateDate = DateTime.Now;
                    commentRepo.Add(comment);
                }
            }
            else
            {
                Console.WriteLine("\t\t\t▌  Comments are empty...");
                Console.WriteLine("\t\t\t▌  Press any key to continue..");
                Console.ReadKey();
            }
        }

        public void List()
        {
            try
            {
                CommentRepository commentRepo = new CommentRepository();
                List<Comment> comments = commentRepo.GetAll(Task.Id);
                if (comments.Count > 0)
                {
                    Console.WriteLine($"\t\t\t▌  Task Id: {Task.Id}");
                    foreach (Comment comment in comments)
                    {
                        Console.WriteLine($"\t\t\t▌  Text: {comment.Text}");
                        Console.WriteLine($"\t\t\t▌  Created Date: {comment.CreateDate}");
                    }
                }
                else
                {
                    Console.WriteLine("\t\t\t▌  Comments are empty...");
                    Console.WriteLine("\t\t\t▌  Press any key to continue..");
                }
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void Add()
        {
            Console.Clear();

            try
            {
                Comment comment = new Comment
                { TaskId = Task.Id, UserId = LoginValidation.LoggedUser.Id, CreateDate = DateTime.Now };

                Console.Write("\t\t\t▌  Text: ");
                comment.Text = Console.ReadLine();
                CommentRepository commentRepo = new CommentRepository();
                commentRepo.Add(comment);

                Console.WriteLine("\t\t\t▌  Comment successfully added!");
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}