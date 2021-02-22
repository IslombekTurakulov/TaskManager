using System;

namespace ManagerLib.User
{
    public class AdminView : IAssingable
    {

        /// <summary>
        /// Shows managements.
        /// </summary>
        public void Show()
        {
            Console.Clear();
            Console.WriteLine("\t\t\t▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬");
            Console.WriteLine("\t\t\t▌  [U]sers Management");
            Console.WriteLine("\t\t\t▌  [T]asks Management");
        }

        /// <summary>
        /// Giving choices
        /// </summary>
        /// <returns></returns>
        public string Choice()
        {
            string choice;

            while (true)
            {
                Console.Write("\t\t\t▌  Type here: ");
                choice = Console.ReadLine()?.ToUpper();

                if (choice != "U" && choice != "T")
                    Console.WriteLine("\t\t\t▌  Invalid choice!");
                else
                    break;
            }

            return choice;
        }
    }
}
