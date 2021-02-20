using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml;
using ManagerLib.Entities;
using Newtonsoft.Json;

namespace ManagerWF.Forms
{
    public partial class AddSubTask : Form
    {
        private string _nameTask;

        public Task Task;

        public int ID { get; set; }

        public int MaxTasks { get; set; }

        public TaskStatusEnum Priority { get; set; }

        public SubTaskStatus StatusSubTask { get; set; }

        public string NameTask
        {
            get => _nameTask;
            set
            {
                if (!NameValidator(value))
                {
                    MessageBox.Show(@"The name must contain only Latin letters, digits and spaces!");
                }
                else
                    _nameTask = value;
            }
        }

        public AddSubTask()
        {
            InitializeComponent();
        }

        private void CreateTaskButton_Click(object sender, EventArgs e)
        {
            var subTask = new SubTask
            {
                Id = ID++,
                Title = NameTask,
                LastEditDate = DateTime.Now,
                Status = StatusSubTask,
                ResponsibleId = "Podbelskiy",
                TaskStatus = Priority
            };

            var json = JsonConvert.SerializeObject(subTask, Newtonsoft.Json.Formatting.Indented);
        }

        private void statusCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            StatusSubTask = (SubTaskStatus)Enum.Parse(typeof(SubTaskStatus), statusCombo.Text);
        }

        private void nameTxtBox_TextChanged(object sender, EventArgs e)
        {
            NameTask = nameTxtBox.Text;
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

        private void priorityCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            Priority = (TaskStatusEnum)Enum.Parse(typeof(TaskStatusEnum), priorityCombo.Text);
        }

        private void maxTasksTxtbox_TextChanged(object sender, EventArgs e)
        {
            int num;
            if (!int.TryParse(maxTasksTxtbox.Text, out num) || (num <= 0 || num >= 30))
                MessageBox.Show("The max-task can't less than zero!");
            else
                MaxTasks = num;

        }
    }
}
