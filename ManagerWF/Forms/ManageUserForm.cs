using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using ManagerLib.Entities;

namespace ManagerWF.Forms
{
    public partial class ManageUserForm : Form
    {
        private List<User> list = new List<User>();
        public int ID { get; set; }
        private string _nameUser;

        public string NameUser
        {
            get => _nameUser;
            set
            {
                if (!NameValidator(value))
                    MessageBox.Show(@"The name must contain only Latin letters, digits and spaces!");
                else
                    _nameUser = value;
            }
        }

        public ManageUserForm()
        {
            InitializeComponent();
        }

        private void AddUser_Load(object sender, EventArgs e)
        {
            LoadTheme();
            if (!File.Exists("UserData.txt"))
                File.Create("UserData.txt");

            Stream fs = new FileStream("UserData.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            int count = 1;

            while (sr.Peek() != -1)
            {
                string[] s = sr.ReadLine()?.Split(" ");
                userDataGrid.Rows.Add(count, s?[0], s?[1] + " " + s?[2]);
                User user = new User
                {
                    Username = s[0],
                    CreateDate = DateTime.Parse(s?[1] + " " + s?[2])
                };
                count++;
                list.Add(user);
            }

            fs.Close();
            sr.Close();
        }

        private void LoadTheme()
        {
            foreach (Control btns in Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                }
            }

            //label4.ForeColor = ThemeColor.SecondaryColor;
            //label5.ForeColor = ThemeColor.PrimaryColor;
        }

        private static bool NameValidator(string name)
        {
            return name.All(letter =>
                letter > 'A' - 1 && letter < 'Z' + 1
                || letter > 'a' - 1 && letter < 'z' + 1
                || char.IsWhiteSpace(letter)
            );
        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
            NameUser = nameTextBox.Text;
        }

        private void CreateTaskButton_Click(object sender, EventArgs e)
        {
            userDataGrid.Rows.Add(ID++, NameUser, DateTime.Now);
            User user = new User
            {
                Username = NameUser,
                CreateDate = DateTime.Now
            };

            list.Add(user);
            Stream fs = new FileStream("UserData.txt", FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            foreach (var item in list)
            {
                sw.WriteLine(item.Username + " " + item.CreateDate);
            }

            sw.Close();
        }
    }
}
