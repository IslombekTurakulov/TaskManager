using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using ManagerLib.Entities;
using Newtonsoft.Json;

namespace ManagerWF.Forms
{
    public partial class AddProject : Form
    {
        private string _nameTask;
        
        public int ID { get; set; }

        public StatusEnum PriorityStatus { get; set; }

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

        public AddProject()
        {
            InitializeComponent();
        }

        private void CreateTaskButton_Click(object sender, EventArgs e)
        {
            var subTask = new Task()
            {
                Id = ID++,
                Title = NameTask,
                LastEditDate = DateTime.Now,
                ResponsibleId = "Podbelskiy",
                Status = PriorityStatus
            };

            var json = JsonConvert.SerializeObject(subTask, Formatting.Indented);
            File.WriteAllText("WFSubTask.json", json + Environment.NewLine);
        }

        private void statusCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            PriorityStatus = (StatusEnum)Enum.Parse(typeof(StatusEnum), statusCombo.Text);
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

    }
}
