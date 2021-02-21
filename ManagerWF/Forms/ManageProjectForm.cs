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
        private List<Task> tasksList = new List<Task>();
        private string ChosenSubTask;
        private Button _currentButton;
        public int ID { get; set; }
        public StatusEnum _projectStatusTask;

        public StatusEnum ProjectStatus
        {
            get => _projectStatusTask;
            set
            {
                switch (value)
                {
                    case StatusEnum.InProgress:
                        _projectStatusTask = (StatusEnum)Enum.Parse(typeof(StatusEnum), "InProgress");
                        break;
                    case StatusEnum.Finished:
                        _projectStatusTask = (StatusEnum)Enum.Parse(typeof(StatusEnum), "Finished");
                        break;
                    case StatusEnum.Opened:
                        _projectStatusTask = (StatusEnum)Enum.Parse(typeof(StatusEnum), "Opened");
                        break;
                    default:
                        _projectStatusTask = (StatusEnum)Enum.Parse(typeof(StatusEnum), "Opened");
                        break;
                }
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


        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (_currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = Color.FromArgb(51, 51, 76);
                    _currentButton = (Button)btnSender;
                    _currentButton.BackColor = color;
                    _currentButton.ForeColor = Color.White;
                    _currentButton.Font = new Font("Microsoft Sans Serif", 12.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
                    ThemeColor.PrimaryColor = color;
                    ThemeColor.SecondaryColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                }
            }
        }

        private void DisableButton()
        {
            CreateTaskButton.BackColor = Color.FromArgb(0, 148, 188);
            _currentButton = null;
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
                }
            }
        }

        private void statusCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProjectStatus = (StatusEnum)Enum.Parse(typeof(StatusEnum), statusCombo.Text);
        }

        private static bool NameValidator(string name)
        {
            return name.All(letter =>
                letter > 'A' - 1 && letter < 'Z' + 1
                || letter > 'a' - 1 && letter < 'z' + 1
                || char.IsWhiteSpace(letter)
            );
        }

        private void CreateTaskButton_Click(object sender, EventArgs e)
        {
            try
            {
                ActivateButton(sender);
                projectDataGrid.Rows.Add(ID++, NameProject, DateTime.Now, ProjectStatus, Responsible, ChosenSubTask);
                var task = new Task
                {
                    Title = NameProject,
                    LastEditDate = DateTime.Now,
                    Status = ProjectStatus,
                    ResponsibleId = Responsible,
                    SubTasks = ChosenSubTask
                };

                tasksList.Add(task);
                Stream fs = new FileStream("ProjectTasks.txt", FileMode.Open, FileAccess.Write);
                StreamWriter sw = new StreamWriter(fs);
                foreach (var item in tasksList)
                {
                    sw.WriteLine(item.Title + " " + item.LastEditDate + " " + item.Status + " " + item.ResponsibleId +
                                 " " + item.SubTasks);
                }

                sw.Close();
                fs.Close();

                MessageBox.Show(@"Project successfully created!");
                DisableButton();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void projectsButton_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);

        }

        private void nameTxtBox_TextChanged(object sender, EventArgs e)
        {
            NameProject = nameTxtBox.Text;
        }

        private void addSubTaskCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChosenSubTask = addSubTaskCombo.Text;
        }

        private void responsibleComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Responsible = responsibleComboBox.Text;
        }

        private void ManageProject_Load(object sender, EventArgs e)
        {
            try
            {
                LoadTheme();
                Stream fs = new FileStream("ProjectTasks.txt", FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);
                int count = 1;

                while (sr.Peek() != -1)
                {
                    string[] projectTaskArr = sr.ReadLine()?.Split(" ");
                    projectDataGrid.Rows.Add(count, projectTaskArr?[0], projectTaskArr?[1] + " " + projectTaskArr?[2],
                        projectTaskArr?[3], projectTaskArr?[4], projectTaskArr?[5]);
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

                Stream subTaskStream = new FileStream("SubTasks.txt", FileMode.Open, FileAccess.Read);
                StreamReader subTaskReader = new StreamReader(subTaskStream);

                while (subTaskReader.Peek() != -1)
                {
                    string[] s = subTaskReader.ReadLine()?.Split(" ");
                    addSubTaskCombo.Items.Add(s?[0] ?? string.Empty);
                }

                Stream userFileStream = new FileStream("UserData.txt", FileMode.Open, FileAccess.Read);
                StreamReader userStreamReader = new StreamReader(userFileStream);

                while (userStreamReader.Peek() != -1)
                {
                    string[] s = userStreamReader.ReadLine()?.Split(" ");
                    responsibleComboBox.Items.Add(s?[0] ?? string.Empty);
                }

                ID = count;
                fs.Close();
                sr.Close();
                subTaskStream.Close();
                subTaskReader.Close();
                userFileStream.Close();
                userStreamReader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
