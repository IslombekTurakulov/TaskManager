using System;
using System.Drawing;
using System.Windows.Forms;

namespace ManagerWF.Forms
{
    public partial class MainManagerInfo : Form
    {

        //Fields
        private Button _currentButton;
        private Form _activeForm;
        private int _tempIndex;

        public MainManagerInfo()
        {
            InitializeComponent();
        }

        private void Project_Load(object sender, EventArgs e)
        {
            LoadTheme();
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

        /// <summary>
        /// Selects theme color.
        /// </summary>
        /// <returns></returns>
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

        /// <summary>
        /// Activates button.
        /// </summary>
        /// <param name="btnSender"></param>
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
                    _currentButton.Font = new Font("Microsoft Sans Serif", 12.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
                    ThemeColor.PrimaryColor = color;
                    ThemeColor.SecondaryColor= ThemeColor.ChangeColorBrightness(color, -0.3);
                }
            }
        }

        /// <summary>
        /// Disables button.
        /// </summary>
        private void DisableButton()
        {
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

        /// <summary>
        /// Open child form in panel <see href="https://rjcodeadvance.com/iu-moderno-temas-multicolor-aleatorio-resaltar-boton-form-activo-winform-c/">Copy from</see>.
        /// </summary>
        /// <param name="childForm"></param>
        /// <param name="btnSender"></param>
        private void OpenChildForm(Form childForm, object btnSender)
        {
            _activeForm?.Close();
            ActivateButton(btnSender);
            _activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            managePanel.Controls.Add(childForm);
            managePanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        /// <summary>
        /// Opens child form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void projectsButton_Click(object sender, EventArgs e) => OpenChildForm(new ManageProject(), sender);

        /// <summary>
        /// Opens child form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void manageTasks_Click(object sender, EventArgs e) => OpenChildForm(new ManageSubTasksForm(), sender);
    }
}
