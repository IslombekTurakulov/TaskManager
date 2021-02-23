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
        private List<User> userList = new List<User>();
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

        /// <summary>
        /// Initializes when form load.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddUser_Load(object sender, EventArgs e)
        {
            try
            {
                // Initializing themes.
                LoadTheme();
                // Creating stream.
                Stream fs = new FileStream("UserData.txt", FileMode.OpenOrCreate, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);
                int count = 1;

                while (sr.Peek() != -1)
                {
                    // Taking from data stream and write.
                    string[] arrayData = sr.ReadLine()?.Split(" ");
                    // Adding to grid.
                    userDataGrid.Rows.Add(count, arrayData?[0], arrayData?[1] + " " + arrayData?[2]);
                   // Creating User object.
                    User user = new User
                    {
                        Username = arrayData?[0],
                        CreateDate = DateTime.Parse(arrayData?[1] + " " + arrayData?[2])
                    };
                    count++;
                    userList.Add(user);
                }

                sr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ooops... Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Loading themes.
        /// </summary>
        private void LoadTheme()
        {
            try
            {
                foreach (Control btns in Controls)
                {
                    if (btns.GetType() == typeof(Button))
                    {
                        Button btn = (Button) btns;
                        btn.BackColor = ThemeColor.PrimaryColor;
                        btn.ForeColor = Color.White;
                        btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ooops... Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Validating name.
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        private static bool NameValidator(string name)
        {
            try
            {
                return name.All(letter =>
                    letter > 'A' - 1 && letter < 'Z' + 1
                    || letter > 'a' - 1 && letter < 'z' + 1
                    || char.IsWhiteSpace(letter)
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ooops... Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return false;
        }
        /// <summary>
        /// Initializing username.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nameTextBox_TextChanged(object sender, EventArgs e) => NameUser = nameTextBox.Text;

        /// <summary>
        /// Create user button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CreateTaskButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Adding data to grid.
                userDataGrid.Rows.Add(ID++, NameUser, DateTime.Now);
                // Creating new User object.
                User user = new User
                {
                    Username = NameUser,
                    CreateDate = DateTime.Now
                };

                userList.Add(user);
                // Initializing Stream.
                Stream fs = new FileStream("UserData.txt", FileMode.OpenOrCreate, FileAccess.Write);
                StreamWriter sw = new StreamWriter(fs);
                foreach (var item in userList)
                {
                    // Writing data.
                    sw.WriteLine(item.Username + " " + item.CreateDate);
                }

                sw.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ooops... Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (userDataGrid.RowCount > 0)
                {
                    foreach (DataGridViewRow row in userDataGrid.SelectedRows)
                    {
                        userDataGrid.Rows.Remove(row);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ManageUserForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            FileStream fs = new FileStream("UserData.txt", FileMode.Create);
            StreamWriter streamWriter = new StreamWriter(fs);

            for (int j = 0; j < userDataGrid.Rows.Count; j++)
            {
                for (int i = 1; i < userDataGrid.Rows[j].Cells.Count; i++)
                {
                    streamWriter.Write(userDataGrid.Rows[j].Cells[i].Value + " ");
                }
                streamWriter.WriteLine();
            }

            streamWriter.Close();
            fs.Close();
        }
    }
}
