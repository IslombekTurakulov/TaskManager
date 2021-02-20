using System;
using System.Data;
using System.IO;
using System.Windows.Forms;
using ManagerLib.Entities;
using Newtonsoft.Json;

namespace ManagerWF.Forms
{
    public partial class ManageSubTasks : Form
    {
        public ManageSubTasks()
        {
            InitializeComponent();
        }

        private void ManageSubTasks_Load(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();
            try
            {
                using StreamReader r = new StreamReader("WFSubTask.json");
                string json = r.ReadToEnd();
                var record = JsonConvert.DeserializeObject<SubTask>(json);
                dataTable.Rows.Add(record.Id, record.Title, record.LastEditDate, record.Status, record.ResponsibleId,
                    record.TaskStatus);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
