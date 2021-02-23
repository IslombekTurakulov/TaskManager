using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using ManagerWF.Forms;

namespace ManagerWF
{
    public partial class MainForm : Form
    {

        // Open child form or Modern Design was taken and enhanced from
        // https://rjcodeadvance.com/iu-moderno-temas-multicolor-aleatorio-resaltar-boton-form-activo-winform-c/

        //Fields
        private Button _currentButton;
        private Random _random;
        private int _tempIndex;
        private Form _activeForm;

        public MainForm()
        {
            InitializeComponent();
            _random = new Random();
            closeChildForm.Visible = false;
            Text = string.Empty;
            ControlBox = false;
            MaximizedBounds = Screen.FromHandle(Handle).WorkingArea;
        }

        /// <summary>
        /// Connecting lib <see href="https://rjcodeadvance.com/iu-moderno-temas-multicolor-aleatorio-resaltar-boton-form-activo-winform-c/">Copy from</see>.
        /// </summary>
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private static extern void ReleaseCapture();

        /// <summary>
        /// Connecting lib <see href="https://rjcodeadvance.com/iu-moderno-temas-multicolor-aleatorio-resaltar-boton-form-activo-winform-c/">Copy from</see>.
        /// </summary>
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private static extern void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);

        /// <summary>
        /// Selecting theme color.
        /// </summary>
        /// <returns></returns>
        private Color SelectThemeColor()
        {
            int index = _random.Next(ThemeColor.ColorList.Count);
            while (_tempIndex.Equals(index))
            {
                index = _random.Next(ThemeColor.ColorList.Count);
            }
            _tempIndex = index;
            var color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }

        /// <summary>
        /// Activates button
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
                    // Changes color.
                    _currentButton.BackColor = color;
                    _currentButton.ForeColor = Color.White;
                    // Changes font.
                    _currentButton.Font = new Font("Microsoft Sans Serif", 12.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
                    panelTitleBar.BackColor = color;
                    // Changes color.
                    panelLogo.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    ThemeColor.PrimaryColor = color;
                    ThemeColor.SecondaryColor= ThemeColor.ChangeColorBrightness(color, -0.3);
                    closeChildForm.Visible = true;
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
                    // Changes color and font.
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
            if (_activeForm != null)
                _activeForm.Close();
            // Initializing buttons.
            ActivateButton(btnSender);
            _activeForm = childForm;
            // Setting up child form.
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            // panelDesktop settings.
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            // Setting up child form.
            childForm.BringToFront();
            childForm.Show();
            labelTitle.Text = childForm.Text;
        }

        /// <summary>
        /// Open child form in panel <see href="https://rjcodeadvance.com/iu-moderno-temas-multicolor-aleatorio-resaltar-boton-form-activo-winform-c/">Copy from</see>.
        /// </summary>
        private void projectsButton_Click(object sender, EventArgs e) => OpenChildForm(new MainManagerInfo(), sender);
        /// <summary>
        ///  Open child form in panel <see href="https://rjcodeadvance.com/iu-moderno-temas-multicolor-aleatorio-resaltar-boton-form-activo-winform-c/">Copy from</see>.
        /// </summary>
        private void addUserButton_Click(object sender, EventArgs e) => OpenChildForm(new ManageUserForm(), sender);
        /// <summary>
        ///  Open child form in panel <see href="https://rjcodeadvance.com/iu-moderno-temas-multicolor-aleatorio-resaltar-boton-form-activo-winform-c/">Copy from</see>.
        /// </summary>
        private void aboutButton_Click(object sender, EventArgs e) => OpenChildForm(new About(), sender);

        /// <summary>
        /// Resets all colors.
        /// </summary>
        private void Reset()
        {
            DisableButton();
            // Reset to title "Home".
            labelTitle.Text = "HOME";
            panelTitleBar.BackColor = Color.FromArgb(0, 150, 136);
            panelLogo.BackColor = Color.FromArgb(39, 39, 58);
            _currentButton = null;
            closeChildForm.Visible = false;
        }

        /// <summary>
        /// Panel title bar.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }

        /// <summary>
        /// Close button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void closeApp_Click(object sender, EventArgs e) => Application.Exit();

        /// <summary>
        /// Close child form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void closeChildForm_Click_1(object sender, EventArgs e)
        {
            if (_activeForm != null)
                _activeForm.Close();
            Reset();
        }

        /// <summary>
        /// Label title.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labelTitle_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }

        /// <summary>
        /// Panel logo.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panelLogo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }

        /// <summary>
        /// Home label.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void homeLabel_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }

        /// <summary>
        /// Exit button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitButton_Click(object sender, EventArgs e) => Application.Exit();

        /// <summary>
        /// Window state changer.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void maximizeWindowBtn_Click(object sender, EventArgs e) => WindowState = WindowState == FormWindowState.Normal ? FormWindowState.Maximized : FormWindowState.Normal;

        /// <summary>
        /// Window state changer.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void minimizeWindowBtn_Click(object sender, EventArgs e) => WindowState = FormWindowState.Minimized;

        /// It initializes when it opens.
        private void MainForm_Load(object sender, EventArgs e) => SelectThemeColor();
    }
}
