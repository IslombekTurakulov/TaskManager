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
        // Fields.
        public Task Task;

        public CommentsManagement(Task task) => Task = task;

        /// <summary>
        /// Menu Comment.
        /// </summary>
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
                    // Back to last menu.
                    AdminView adminView = new AdminView();
                    adminView.Show();
                    adminView.Choice();
                    break;
                }
                Console.WriteLine("\t\t\t▌  Invalid choice!");
            }
        }

        /// <summary>
        /// Edit comment entity.
        /// </summary>
        protected void EditEntity()
        {
            // Creating new class of repo.
            CommentRepository commentRepo = new CommentRepository();
            // Taking comments.
            List<Comment> comments = commentRepo.GetAll(Task.Id);

            if (comments.Count > 0)
            {
                foreach (var comment in comments)
                {
                    // Write the data of comment.
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

        /// <summary>
        /// Show list of comments.
        /// </summary>
        public void List()
        {
            try
            {
                // Creating new class of comment.
                CommentRepository commentRepo = new CommentRepository();
                // Getting the list of comments.
                List<Comment> comments = commentRepo.GetAll(Task.Id);
                if (comments.Count > 0)
                {
                    Console.WriteLine($"\t\t\t▌  Task Id: {Task.Id}");
                    // Show the info about the comment.
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

        /// <summary>
        /// Add.
        /// </summary>
        private void Add()
        {
            Console.Clear();

            try
            {
                // Creating new object class.
                Comment comment = new Comment
                { TaskId = Task.Id, UserId = LoginValidation.LoggedUser.Id, CreateDate = DateTime.Now };

                Console.Write("\t\t\t▌  Text: ");
                comment.Text = Console.ReadLine();

                // Creating new class of comment repository.
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