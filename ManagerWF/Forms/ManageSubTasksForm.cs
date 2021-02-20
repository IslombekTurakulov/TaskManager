using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using ManagerLib.Entities;
using Newtonsoft.Json;

namespace ManagerWF.Forms
{
    public partial class ManageSubTasksForm : Form
    {
        private List<SubTask> subTasksList = new List<SubTask>();
        public int ID { get; set; }
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

                fs.Close();
                sr.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void nameTxtBox_TextChanged(object sender, EventArgs e)
        {
            TitleSubTask = nameTxtBox.Text;
        }

        private void CreateTaskButton_Click(object sender, EventArgs e)
        {

        }

        private void statusCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void priorityCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void maxTasksTxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void responsibleComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
