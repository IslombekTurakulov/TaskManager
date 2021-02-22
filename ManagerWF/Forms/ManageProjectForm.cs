using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using ManagerLib.Entities;

namespace ManagerWF.Forms
{
    public partial class ManageProject : Form
    {
        // Initializing variable.
        private List<Task> tasksList = new List<Task>();
        private string ChosenSubTask;

        public int ID { get; set; }

        // Enums.
        public StatusEnum _projectStatusTask;

        public StatusEnum ProjectStatus
        {
            get => _projectStatusTask;
            set
            {
                _projectStatusTask = value switch
                {
                    StatusEnum.InProgress => (StatusEnum) Enum.Parse(typeof(StatusEnum), "InProgress"),
                    StatusEnum.Finished => (StatusEnum) Enum.Parse(typeof(StatusEnum), "Finished"),
                    StatusEnum.Opened => (StatusEnum) Enum.Parse(typeof(StatusEnum), "Opened"),
                    _ => (StatusEnum) Enum.Parse(typeof(StatusEnum), "Opened")
                };
            }
        }

        public string Responsible { get; set; }

        private string _nameProject;

        public string NameProject
        {
            get => _nameProject;
            set
            {
                if (!NameValidator(value))
                    MessageBox.Show(@"The name must contain only Latin letters, digits and spaces!");
                else
                    _nameProject = value;
            }
        }


        public ManageProject()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 
        /// </summary>
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

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void statusCombo_SelectedIndexChanged(object sender, EventArgs e) =>
            ProjectStatus = (StatusEnum)Enum.Parse(typeof(StatusEnum), statusCombo.Text);

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
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }
        /// <summary>
        /// Creating project.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CreateTaskButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Adding data to grid.
                projectDataGrid.Rows.Add(ID++, NameProject, DateTime.Now, ProjectStatus, Responsible, ChosenSubTask);

                // Creating new object.
                var task = new Task
                {
                    Title = NameProject,
                    LastEditDate = DateTime.Now,
                    Status = ProjectStatus,
                    ResponsibleId = Responsible,
                    SubTasks = ChosenSubTask
                };

                tasksList.Add(task);

                // Initializing stream to write data to file.
                Stream fs = new FileStream("ProjectTasks.txt", FileMode.Open, FileAccess.Write);
                StreamWriter sw = new StreamWriter(fs);
                foreach (var item in tasksList)
                {
                    sw.WriteLine(item.Title + " " + item.LastEditDate + " " + item.Status + " " + item.ResponsibleId +
                                 " " + item.SubTasks);
                }

                sw.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Writes name project.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nameTxtBox_TextChanged(object sender, EventArgs e) => NameProject = nameTxtBox.Text;

        /// <summary>
        /// Add Sub Task.
        /// </summary>
        /// <param name="sender" />
        /// <param name="e" />
        private void addSubTaskCombo_SelectedIndexChanged(object sender, EventArgs e) =>
            ChosenSubTask = addSubTaskCombo.Text;

        /// <summary /> Choose Responsible user.
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void responsibleComboBox_SelectedIndexChanged(object sender, EventArgs e) => Responsible = responsibleComboBox.Text;

        /// <summary>
        /// It initializing when this form starts.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ManageProject_Load(object sender, EventArgs e)
        {
            try
            {
                // Loading themes.
                LoadTheme();

                // Initializing Stream
                Stream fs = new FileStream("ProjectTasks.txt", FileMode.OpenOrCreate, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);
                int count = 1;

                // Reading data and adding to grid
                while (sr.Peek() != -1)
                {
                    string[] projectTaskArr = sr.ReadLine()?.Split(" ");
                    projectDataGrid.Rows.Add(count, projectTaskArr?[0], projectTaskArr?[1] + " " + projectTaskArr?[2],
                        projectTaskArr?[3], projectTaskArr?[4], projectTaskArr?[5]);
                    // Creating Task object
                    var task = new Task
                    {
                        Title = projectTaskArr?[0],
                        LastEditDate = DateTime.Parse(projectTaskArr?[1] + " " + projectTaskArr?[2]),
                        Status = (StatusEnum)Enum.Parse(typeof(StatusEnum), projectTaskArr?[3] ?? string.Empty),
                        ResponsibleId = projectTaskArr?[4],
                        SubTasks = projectTaskArr?[5]
                    };

                    tasksList.Add(task);
                    count++;
                }

                // Initializing new Stream.
                Stream subTaskStream = new FileStream("SubTasks.txt", FileMode.OpenOrCreate, FileAccess.Read);
                StreamReader subTaskReader = new StreamReader(subTaskStream);

                // Reading data and adding to combo-box
                while (subTaskReader.Peek() != -1)
                {
                    string[] s = subTaskReader.ReadLine()?.Split(" ");
                    addSubTaskCombo.Items.Add(s?[0] ?? string.Empty);
                }

                // Initializing new Stream.
                Stream userFileStream = new FileStream("UserData.txt", FileMode.OpenOrCreate, FileAccess.Read);
                StreamReader userStreamReader = new StreamReader(userFileStream);

                // Reading data and adding to combo-box.
                while (userStreamReader.Peek() != -1)
                {
                    string[] s = userStreamReader.ReadLine()?.Split(" ");
                    responsibleComboBox.Items.Add(s?[0] ?? string.Empty);
                }

                // Variable ID.
                ID = count;

                fs.Close();
                subTaskReader.Close();
                userStreamReader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ooops... Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (projectDataGrid.RowCount > 0)
                {
                    foreach (DataGridViewRow row in projectDataGrid.SelectedRows)
                    {
                        projectDataGrid.Rows.Remove(row);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
