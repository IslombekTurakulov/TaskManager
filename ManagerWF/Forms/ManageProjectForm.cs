using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using ManagerLib.Entities;
using Newtonsoft.Json;

namespace ManagerWF.Forms
{
    public partial class ManageProject : Form
    {
        //Fields
        private Button _currentButton;
        private Form _activeForm;
        private int _tempIndex;

        public StatusEnum PriorityStatus { get; set; }

        public int ID { get; set; }

        private string _nameTask;

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

        private Color SelectThemeColor()
        {
            int index = 2;
            while (_tempIndex.Equals(index))
            {
                index = 3;
            }
            _tempIndex = index;
            var color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (_currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    _currentButton = (Button)btnSender;
                    _currentButton.BackColor = color;
                    _currentButton.ForeColor = Color.White;
                    _currentButton.Font = new Font("Microsoft Sans Serif", 12.5F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
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
                    previousBtn.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        private void statusCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            PriorityStatus = (StatusEnum)Enum.Parse(typeof(StatusEnum), statusCombo.Text);
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

        private void CreateTaskButton_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            var subTask = new Task()
            {
                Id = ID++,
                Title = NameTask,
                LastEditDate = DateTime.Now,
                ResponsibleId = "Podbelskiy",
                Status = PriorityStatus
            };

            var json = JsonConvert.SerializeObject(subTask, Formatting.Indented);



            MessageBox.Show("Project successfully created!");


            DisableButton();
        }

        private void projectsButton_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
           
        }

        private void nameTxtBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
