
using System.ComponentModel;
using System.Windows.Forms;

namespace ManagerWF.Forms
{
    partial class ManageSubTasksForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageSubTasksForm));
            this.subTaskDataGrid = new System.Windows.Forms.DataGridView();
            this.IDColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TitleColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreationDateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ResponsibleColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Priority = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.responsibleLabel = new System.Windows.Forms.Label();
            this.responsibleComboBox = new System.Windows.Forms.ComboBox();
            this.CreateTaskButton = new System.Windows.Forms.Button();
            this.priorityTask = new System.Windows.Forms.Label();
            this.MaxTasksLabel = new System.Windows.Forms.Label();
            this.priorityCombo = new System.Windows.Forms.ComboBox();
            this.maxTasksTxtbox = new System.Windows.Forms.TextBox();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.statusCombo = new System.Windows.Forms.ComboBox();
            this.nameTxtBox = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.deleteButton = new System.Windows.Forms.Button();
            this.projectsButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.subTaskDataGrid)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // subTaskDataGrid
            // 
            this.subTaskDataGrid.AllowUserToAddRows = false;
            this.subTaskDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.subTaskDataGrid.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.subTaskDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.subTaskDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDColumn,
            this.TitleColumn,
            this.CreationDateColumn,
            this.StatusColumn,
            this.ResponsibleColumn,
            this.Priority});
            this.subTaskDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.subTaskDataGrid.Location = new System.Drawing.Point(0, 0);
            this.subTaskDataGrid.Name = "subTaskDataGrid";
            this.subTaskDataGrid.ReadOnly = true;
            this.subTaskDataGrid.RowTemplate.Height = 25;
            this.subTaskDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.subTaskDataGrid.Size = new System.Drawing.Size(800, 385);
            this.subTaskDataGrid.TabIndex = 2;
            // 
            // IDColumn
            // 
            this.IDColumn.HeaderText = "ID";
            this.IDColumn.Name = "IDColumn";
            this.IDColumn.ReadOnly = true;
            // 
            // TitleColumn
            // 
            this.TitleColumn.HeaderText = "Title";
            this.TitleColumn.Name = "TitleColumn";
            this.TitleColumn.ReadOnly = true;
            // 
            // CreationDateColumn
            // 
            this.CreationDateColumn.HeaderText = "Creation Date";
            this.CreationDateColumn.Name = "CreationDateColumn";
            this.CreationDateColumn.ReadOnly = true;
            // 
            // StatusColumn
            // 
            this.StatusColumn.HeaderText = "StatusSubTask";
            this.StatusColumn.Name = "StatusColumn";
            this.StatusColumn.ReadOnly = true;
            // 
            // ResponsibleColumn
            // 
            this.ResponsibleColumn.HeaderText = "Responsible";
            this.ResponsibleColumn.Name = "ResponsibleColumn";
            this.ResponsibleColumn.ReadOnly = true;
            // 
            // Priority
            // 
            this.Priority.HeaderText = "Priority";
            this.Priority.Name = "Priority";
            this.Priority.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panelMenu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(940, 385);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(148)))), ((int)(((byte)(188)))));
            this.panel2.Controls.Add(this.responsibleLabel);
            this.panel2.Controls.Add(this.responsibleComboBox);
            this.panel2.Controls.Add(this.CreateTaskButton);
            this.panel2.Controls.Add(this.priorityTask);
            this.panel2.Controls.Add(this.MaxTasksLabel);
            this.panel2.Controls.Add(this.priorityCombo);
            this.panel2.Controls.Add(this.maxTasksTxtbox);
            this.panel2.Controls.Add(this.StatusLabel);
            this.panel2.Controls.Add(this.NameLabel);
            this.panel2.Controls.Add(this.statusCombo);
            this.panel2.Controls.Add(this.nameTxtBox);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(140, 267);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 118);
            this.panel2.TabIndex = 4;
            // 
            // responsibleLabel
            // 
            this.responsibleLabel.AutoSize = true;
            this.responsibleLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.responsibleLabel.Location = new System.Drawing.Point(540, 39);
            this.responsibleLabel.Name = "responsibleLabel";
            this.responsibleLabel.Size = new System.Drawing.Size(106, 21);
            this.responsibleLabel.TabIndex = 10;
            this.responsibleLabel.Text = "Responsible:";
            // 
            // responsibleComboBox
            // 
            this.responsibleComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.responsibleComboBox.FormattingEnabled = true;
            this.responsibleComboBox.Location = new System.Drawing.Point(553, 70);
            this.responsibleComboBox.Name = "responsibleComboBox";
            this.responsibleComboBox.Size = new System.Drawing.Size(87, 23);
            this.responsibleComboBox.TabIndex = 9;
            this.responsibleComboBox.SelectedIndexChanged += new System.EventHandler(this.responsibleComboBox_SelectedIndexChanged);
            // 
            // CreateTaskButton
            // 
            this.CreateTaskButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(148)))), ((int)(((byte)(188)))));
            this.CreateTaskButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.CreateTaskButton.FlatAppearance.BorderSize = 0;
            this.CreateTaskButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateTaskButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CreateTaskButton.Image = ((System.Drawing.Image)(resources.GetObject("CreateTaskButton.Image")));
            this.CreateTaskButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CreateTaskButton.Location = new System.Drawing.Point(701, 0);
            this.CreateTaskButton.Name = "CreateTaskButton";
            this.CreateTaskButton.Size = new System.Drawing.Size(99, 118);
            this.CreateTaskButton.TabIndex = 8;
            this.CreateTaskButton.Text = "Create Task";
            this.CreateTaskButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.CreateTaskButton.UseVisualStyleBackColor = false;
            this.CreateTaskButton.Click += new System.EventHandler(this.CreateTaskButton_Click);
            // 
            // priorityTask
            // 
            this.priorityTask.AutoSize = true;
            this.priorityTask.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.priorityTask.Location = new System.Drawing.Point(327, 25);
            this.priorityTask.Name = "priorityTask";
            this.priorityTask.Size = new System.Drawing.Size(71, 21);
            this.priorityTask.TabIndex = 7;
            this.priorityTask.Text = "Priority:";
            // 
            // MaxTasksLabel
            // 
            this.MaxTasksLabel.AutoSize = true;
            this.MaxTasksLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MaxTasksLabel.Location = new System.Drawing.Point(309, 72);
            this.MaxTasksLabel.Name = "MaxTasksLabel";
            this.MaxTasksLabel.Size = new System.Drawing.Size(89, 21);
            this.MaxTasksLabel.TabIndex = 6;
            this.MaxTasksLabel.Text = "Max tasks:";
            // 
            // priorityCombo
            // 
            this.priorityCombo.AutoCompleteCustomSource.AddRange(new string[] {
            "Epic",
            "Bug",
            "Task",
            "Story"});
            this.priorityCombo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.priorityCombo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.priorityCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.priorityCombo.FormattingEnabled = true;
            this.priorityCombo.Items.AddRange(new object[] {
            "Epic",
            "Bug",
            "Task",
            "Story"});
            this.priorityCombo.Location = new System.Drawing.Point(404, 25);
            this.priorityCombo.Name = "priorityCombo";
            this.priorityCombo.Size = new System.Drawing.Size(100, 23);
            this.priorityCombo.TabIndex = 5;
            this.priorityCombo.SelectedIndexChanged += new System.EventHandler(this.priorityCombo_SelectedIndexChanged);
            // 
            // maxTasksTxtbox
            // 
            this.maxTasksTxtbox.Location = new System.Drawing.Point(404, 72);
            this.maxTasksTxtbox.Name = "maxTasksTxtbox";
            this.maxTasksTxtbox.PlaceholderText = "For example: 2";
            this.maxTasksTxtbox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.maxTasksTxtbox.Size = new System.Drawing.Size(100, 23);
            this.maxTasksTxtbox.TabIndex = 4;
            this.maxTasksTxtbox.TextChanged += new System.EventHandler(this.maxTasksTxtbox_TextChanged);
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.StatusLabel.Location = new System.Drawing.Point(46, 23);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(124, 21);
            this.StatusLabel.TabIndex = 3;
            this.StatusLabel.Text = "StatusSubTask:";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NameLabel.Location = new System.Drawing.Point(46, 70);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(94, 21);
            this.NameLabel.TabIndex = 2;
            this.NameLabel.Text = "NameTask:";
            // 
            // statusCombo
            // 
            this.statusCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.statusCombo.FormattingEnabled = true;
            this.statusCombo.Items.AddRange(new object[] {
            "InProgress",
            "Finished",
            "Opened"});
            this.statusCombo.Location = new System.Drawing.Point(185, 20);
            this.statusCombo.Name = "statusCombo";
            this.statusCombo.Size = new System.Drawing.Size(100, 23);
            this.statusCombo.TabIndex = 1;
            this.statusCombo.SelectedIndexChanged += new System.EventHandler(this.statusCombo_SelectedIndexChanged);
            // 
            // nameTxtBox
            // 
            this.nameTxtBox.Location = new System.Drawing.Point(161, 70);
            this.nameTxtBox.Name = "nameTxtBox";
            this.nameTxtBox.PlaceholderText = "Type your task";
            this.nameTxtBox.Size = new System.Drawing.Size(100, 23);
            this.nameTxtBox.TabIndex = 0;
            this.nameTxtBox.TextChanged += new System.EventHandler(this.nameTxtBox_TextChanged);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.subTaskDataGrid);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(140, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(800, 385);
            this.panel3.TabIndex = 6;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelMenu.Controls.Add(this.deleteButton);
            this.panelMenu.Controls.Add(this.projectsButton);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(140, 385);
            this.panelMenu.TabIndex = 5;
            // 
            // deleteButton
            // 
            this.deleteButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.deleteButton.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.deleteButton.FlatAppearance.BorderSize = 0;
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.deleteButton.ForeColor = System.Drawing.Color.White;
            this.deleteButton.Image = ((System.Drawing.Image)(resources.GetObject("deleteButton.Image")));
            this.deleteButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.deleteButton.Location = new System.Drawing.Point(0, 60);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.deleteButton.Size = new System.Drawing.Size(140, 60);
            this.deleteButton.TabIndex = 4;
            this.deleteButton.Text = "  Delete Sub-Task";
            this.deleteButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // projectsButton
            // 
            this.projectsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.projectsButton.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.projectsButton.FlatAppearance.BorderSize = 0;
            this.projectsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.projectsButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.projectsButton.ForeColor = System.Drawing.Color.White;
            this.projectsButton.Image = ((System.Drawing.Image)(resources.GetObject("projectsButton.Image")));
            this.projectsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.projectsButton.Location = new System.Drawing.Point(0, 0);
            this.projectsButton.Name = "projectsButton";
            this.projectsButton.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.projectsButton.Size = new System.Drawing.Size(140, 60);
            this.projectsButton.TabIndex = 2;
            this.projectsButton.Text = "  Sub-Tasks";
            this.projectsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.projectsButton.UseVisualStyleBackColor = true;
            // 
            // ManageSubTasksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 385);
            this.Controls.Add(this.panel1);
            this.Name = "ManageSubTasksForm";
            this.Text = "ManageSubTasks";
            this.Load += new System.EventHandler(this.ManageSubTasks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.subTaskDataGrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView subTaskDataGrid;
        private DataGridViewTextBoxColumn IDColumn;
        private DataGridViewTextBoxColumn TitleColumn;
        private DataGridViewTextBoxColumn CreationDateColumn;
        private DataGridViewTextBoxColumn StatusColumn;
        private DataGridViewTextBoxColumn ResponsibleColumn;
        private DataGridViewTextBoxColumn Priority;
        private Panel panel1;
        private Panel panel2;
        private Button CreateTaskButton;
        private Label priorityTask;
        private Label MaxTasksLabel;
        private ComboBox priorityCombo;
        private TextBox maxTasksTxtbox;
        private Label StatusLabel;
        private Label NameLabel;
        private ComboBox statusCombo;
        private TextBox nameTxtBox;
        private Label responsibleLabel;
        private ComboBox responsibleComboBox;
        private Panel panel3;
        private Panel panelMenu;
        private Button projectsButton;
        private Button deleteButton;
    }
}