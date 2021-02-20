using System;
using System.Drawing;
using System.Windows.Forms;

namespace ManagerWF.Forms
{
    public partial class SubTaskForm : Form
    {

        //Fields
        private Button _currentButton;
        private int _tempIndex;
        private Form _activeForm;

        public SubTaskForm()
        {
            InitializeComponent();
        }

         private Color SelectThemeColor()
        {
            int index = 2;
            while (_tempIndex.Equals(index))
            {
                index = 4;
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
                    ThemeColor.SecondaryColor= ThemeColor.ChangeColorBrightness(color, -0.3);
                }
            }
        }

        private void DisableButton()
        {
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

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (_activeForm != null)
                _activeForm.Close();
            ActivateButton(btnSender);
            _activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            subTaskPanel.Controls.Add(childForm);
            subTaskPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void manageTasks_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AddSubTask(), sender);
        }

        private void projectsButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ManageSubTasks(), sender);
        }
    }
}
