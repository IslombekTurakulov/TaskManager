using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using ManagerLib.Entities;

namespace ManagerWF.Forms
{
    public partial class ManageSubTasksForm : Form
    {
        private List<SubTask> subTasksList = new List<SubTask>();
        public int ID { get; set; }
       
        public TaskStatusEnum _priorityStatus;

        public SubTaskStatus _subTaskStatus;

        private int _maxTasks;
        public int MaxTasks { get; set; }

        public TaskStatusEnum PriorityStatus
        {
            get => _priorityStatus;
            set
            {
                switch (value)
                {
                    case TaskStatusEnum.Epic:
                        _priorityStatus = (TaskStatusEnum)Enum.Parse(typeof(TaskStatusEnum), "Epic");
                        break;
                    case TaskStatusEnum.Task:
                        _priorityStatus = (TaskStatusEnum)Enum.Parse(typeof(TaskStatusEnum), "Task");
                        break;
                    case TaskStatusEnum.Bug:
                        _priorityStatus = (TaskStatusEnum)Enum.Parse(typeof(TaskStatusEnum), "Bug");
                        break;
                    case TaskStatusEnum.Story:
                        _priorityStatus = (TaskStatusEnum)Enum.Parse(typeof(TaskStatusEnum), "Story");
                        break;
                    default:
                        _priorityStatus = (TaskStatusEnum)Enum.Parse(typeof(TaskStatusEnum), "Task");
                        break;
                }
            }
        }

        public SubTaskStatus SubTaskStatus
        {
            get => _subTaskStatus;
            set
            {
                switch (value)
                {
                    case SubTaskStatus.InProgress:
                        _subTaskStatus = (SubTaskStatus)Enum.Parse(typeof(SubTaskStatus), "InProgress");
                        break;
                    case SubTaskStatus.Finished:
                        _subTaskStatus = (SubTaskStatus)Enum.Parse(typeof(SubTaskStatus), "Finished");
                        break;
                    case SubTaskStatus.Opened:
                        _subTaskStatus = (SubTaskStatus)Enum.Parse(typeof(SubTaskStatus), "Opened");
                        break;
                    default:
                        _subTaskStatus = (SubTaskStatus)Enum.Parse(typeof(SubTaskStatus), "Opened");
                        break;
                }
            }
        }
        private string _responsible;

        public string Responsible
        {
            get => _responsible;
            set
            {
                if (!NameValidator(value))
                    MessageBox.Show(@"The name must contain only Latin letters, digits and spaces!");
                else
                    _responsible = value;
            }
        }

        private string _titleSubTask;

        public string TitleSubTask
        {
            get => _titleSubTask;
            set
            {
                if (!NameValidator(value))
                    MessageBox.Show(@"The name must contain only Latin letters, digits and spaces!");
                else
                    _titleSubTask = value;
            }
        }


        public ManageSubTasksForm()
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

            //label4.ForeColor = ThemeColor.SecondaryColor;
            //label5.ForeColor = ThemeColor.PrimaryColor;
        }

        private static bool NameValidator(string name)
        {
            return name.All(letter =>
                letter > 'A' - 1 && letter < 'Z' + 1
                || letter > 'a' - 1 && letter < 'z' + 1
                || char.IsWhiteSpace(letter)
                || char.IsDigit(letter)
            );
        }

        private void ManageSubTasks_Load(object sender, EventArgs e)
        {
            try
            {
                LoadTheme();
                Stream fs = new FileStream("SubTasks.txt", FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);
                int count = 1;

                while (sr.Peek() != -1)
                {
                    string[] s = sr.ReadLine()?.Split(" ");
                    subTaskDataGrid.Rows.Add(count, s?[0], s?[1] + " " + s?[2], s?[3], s?[4], s[5]);
                    count++;
                }

                Stream userFileStream = new FileStream("UserData.txt", FileMode.Open, FileAccess.Read);
                StreamReader userStreamReader = new StreamReader(userFileStream);

                while (userStreamReader.Peek() != -1)
                {
                    string[] s = userStreamReader.ReadLine()?.Split(" ");
                    responsibleComboBox.Items.Add(s?[0]);
                }

                fs.Close();
                sr.Close();
                userFileStream.Close();
                userStreamReader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void nameTxtBox_TextChanged(object sender, EventArgs e)
        {
            TitleSubTask = nameTxtBox.Text;
        }

        private void CreateTaskButton_Click(object sender, EventArgs e)
        {
            subTaskDataGrid.Rows.Add(ID++, TitleSubTask, DateTime.Now, SubTaskStatus, Responsible, PriorityStatus);
            SubTask user = new SubTask
            {
                Title = TitleSubTask,
                LastEditDate = DateTime.Now,
                Status = SubTaskStatus,
                ResponsibleId = Responsible,
                TaskStatus = PriorityStatus,
            };

            subTasksList.Add(user);
            Stream fs = new FileStream("SubTasks.txt", FileMode.Open, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            foreach (var item in subTasksList)
            {
                sw.WriteLine(item.Title + " " + item.LastEditDate + " " + item.Status + " " + item.ResponsibleId + " " + item.TaskStatus);
            }

            sw.Close();
            fs.Close();
        }

        private void statusCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            SubTaskStatus = (SubTaskStatus)Enum.Parse(typeof(SubTaskStatus), statusCombo.Text);
        }

        private void priorityCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            PriorityStatus = (TaskStatusEnum)Enum.Parse(typeof(TaskStatusEnum), priorityCombo.Text);
            if (PriorityStatus == TaskStatusEnum.Epic)
            {
                responsibleLabel.Visible = false;
                responsibleComboBox.Visible = false;
            }
            else
            {
                responsibleLabel.Visible = true;
                responsibleComboBox.Visible = true;
            }
        }

        private void maxTasksTxtbox_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(maxTasksTxtbox.Text, out _maxTasks) || _maxTasks <= 0 || _maxTasks >= Int32.MaxValue)
            {
                MessageBox.Show(@"Incorrect input");
            }
            else
            {
                MaxTasks = _maxTasks;
            }
        }

        private void responsibleComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Responsible = responsibleComboBox.Text;
        }

    }
}
