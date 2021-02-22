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

        // Enums.
        public TaskStatusEnum _priorityStatus;

        public SubTaskStatus _subTaskStatus;

        private int _maxTasks;
        public int MaxTasks { get; set; }

        // Enum
        public TaskStatusEnum PriorityStatus
        {
            get => _priorityStatus;
            set
            {
                // Checking the field.
                _priorityStatus = value switch
                {
                    TaskStatusEnum.Epic => (TaskStatusEnum)Enum.Parse(typeof(TaskStatusEnum), "Epic"),
                    TaskStatusEnum.Task => (TaskStatusEnum)Enum.Parse(typeof(TaskStatusEnum), "Task"),
                    TaskStatusEnum.Bug => (TaskStatusEnum)Enum.Parse(typeof(TaskStatusEnum), "Bug"),
                    TaskStatusEnum.Story => (TaskStatusEnum)Enum.Parse(typeof(TaskStatusEnum), "Story"),
                    _ => (TaskStatusEnum)Enum.Parse(typeof(TaskStatusEnum), "Task")
                };
            }
        }

        public SubTaskStatus SubTaskStatus
        {
            get => _subTaskStatus;
            set
            {
                // Checking the field.
                _subTaskStatus = value switch
                {
                    SubTaskStatus.InProgress => (SubTaskStatus)Enum.Parse(typeof(SubTaskStatus), "InProgress"),
                    SubTaskStatus.Finished => (SubTaskStatus)Enum.Parse(typeof(SubTaskStatus), "Finished"),
                    SubTaskStatus.Opened => (SubTaskStatus)Enum.Parse(typeof(SubTaskStatus), "Opened"),
                    _ => (SubTaskStatus)Enum.Parse(typeof(SubTaskStatus), "Opened")
                };
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

        /// <summary>
        /// Loading themes <see href="https://rjcodeadvance.com/iu-moderno-temas-multicolor-aleatorio-resaltar-boton-form-activo-winform-c/">Copy from</see>.
        /// </summary>
        private void LoadTheme()
        {
            try
            {

                foreach (Control btns in Controls)
                {
                    if (btns.GetType() == typeof(Button))
                    {
                        // Initializing button to current colors.
                        Button btn = (Button)btns;
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
        /// Validating names.
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
        /// While opening form , loading this event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ManageSubTasks_Load(object sender, EventArgs e)
        {
            try
            {
                // Loading themes.
                LoadTheme();
                // Creating Stream to read from file.
                Stream fs = new FileStream("SubTasks.txt", FileMode.OpenOrCreate, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);
                int count = 1;

                while (sr.Peek() != -1)
                {
                    // Initializing to array and adding to data grid
                    string[] arrayData = sr.ReadLine().Split(" ");
                    subTaskDataGrid.Rows.Add(count, arrayData?[0], arrayData?[1] + " " + arrayData?[2], arrayData?[3], arrayData?[4], arrayData?[5]);
                    // It helps to count the current tasks.
                    // Creating Task object
                    var task = new SubTask()
                    {
                        Title = arrayData?[0],
                        LastEditDate = DateTime.Parse(arrayData?[1] + " " + arrayData?[2]),
                        Status =(SubTaskStatus)Enum.Parse(typeof(SubTaskStatus),  arrayData?[3]),
                        ResponsibleId = arrayData?[4],
                        TaskStatus = (TaskStatusEnum)Enum.Parse(typeof(TaskStatusEnum),  arrayData?[5]),
                    };
                    subTasksList.Add(task);
                    count++;
                }

                fs.Close();

                // Creating Stream to read from file.
                Stream userFileStream = new FileStream("UserData.txt", FileMode.OpenOrCreate, FileAccess.Read);
                StreamReader userStreamReader = new StreamReader(userFileStream);

                while (userStreamReader.Peek() != -1)
                {
                    // Initializing to array and adding to data grid.
                    string[] arrayData = userStreamReader.ReadLine()?.Split(" ");
                    responsibleComboBox.Items.Add(arrayData?[0] ?? string.Empty);
                }
                // Count is ID variable
                ID = count;
                userFileStream.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ooops... Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Write Title for Sub-Task.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nameTxtBox_TextChanged(object sender, EventArgs e) => TitleSubTask = nameTxtBox.Text;

        /// <summary>
        /// Creates task button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CreateTaskButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Adding data to grid.
                if (PriorityStatus == TaskStatusEnum.Epic)
                {
                    Responsible = "None";
                    subTaskDataGrid.Rows.Add(ID++, TitleSubTask, DateTime.Now, SubTaskStatus, Responsible, PriorityStatus);
                }
                else
                    subTaskDataGrid.Rows.Add(ID++, TitleSubTask, DateTime.Now, SubTaskStatus, Responsible, PriorityStatus);

                // Creating new object Sub-Task.
                SubTask user = new SubTask
                {
                    Title = TitleSubTask,
                    LastEditDate = DateTime.Now,
                    Status = SubTaskStatus,
                    ResponsibleId = Responsible,
                    TaskStatus = PriorityStatus,
                };
                subTasksList.Add(user);

                // Creating Stream function to write data
                Stream fs = new FileStream("SubTasks.txt", FileMode.Open, FileAccess.Write);
                StreamWriter sw = new StreamWriter(fs);
                foreach (var item in subTasksList)
                {
                    sw.WriteLine($"{item.Title} {item.LastEditDate} {item.Status} {item.ResponsibleId} {item.TaskStatus}");
                }

                sw.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Choose Sub-Task status.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void statusCombo_SelectedIndexChanged(object sender, EventArgs e) =>
            SubTaskStatus = (SubTaskStatus)Enum.Parse(typeof(SubTaskStatus), statusCombo.Text);

        /// <summary>
        /// Choose Priority Status.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void priorityCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Write Max Tasks. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void maxTasksTxtbox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(maxTasksTxtbox.Text, out _maxTasks) || _maxTasks <= 0 || _maxTasks >= Int32.MaxValue)
                    MessageBox.Show(@"Incorrect input");
                else
                    MaxTasks = _maxTasks;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Choose responsible user.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void responsibleComboBox_SelectedIndexChanged(object sender, EventArgs e) => Responsible = responsibleComboBox.Text;

        /// <summary>
        /// Delete Data from Grid.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (subTaskDataGrid.RowCount > 0)
                {
                    foreach (DataGridViewRow row in subTaskDataGrid.SelectedRows)
                    {
                        subTaskDataGrid.Rows.Remove(row);
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
