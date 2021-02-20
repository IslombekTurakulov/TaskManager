﻿
namespace ManagerWF.Forms
{
    partial class ManageSubTasksForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.CreateTaskButton = new System.Windows.Forms.Button();
            this.priorityTask = new System.Windows.Forms.Label();
            this.MaxTasksLabel = new System.Windows.Forms.Label();
            this.priorityCombo = new System.Windows.Forms.ComboBox();
            this.maxTasksTxtbox = new System.Windows.Forms.TextBox();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.statusCombo = new System.Windows.Forms.ComboBox();
            this.nameTxtBox = new System.Windows.Forms.TextBox();
            this.responsibleLabel = new System.Windows.Forms.Label();
            this.responsibleComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.subTaskDataGrid)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // subTaskDataGrid
            // 
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
            this.subTaskDataGrid.RowTemplate.Height = 25;
            this.subTaskDataGrid.Size = new System.Drawing.Size(800, 450);
            this.subTaskDataGrid.TabIndex = 2;
            // 
            // IDColumn
            // 
            this.IDColumn.HeaderText = "ID";
            this.IDColumn.Name = "IDColumn";
            // 
            // TitleColumn
            // 
            this.TitleColumn.HeaderText = "Title";
            this.TitleColumn.Name = "TitleColumn";
            // 
            // CreationDateColumn
            // 
            this.CreationDateColumn.HeaderText = "Creation Date";
            this.CreationDateColumn.Name = "CreationDateColumn";
            // 
            // StatusColumn
            // 
            this.StatusColumn.HeaderText = "StatusSubTask";
            this.StatusColumn.Name = "StatusColumn";
            // 
            // ResponsibleColumn
            // 
            this.ResponsibleColumn.HeaderText = "Responsible";
            this.ResponsibleColumn.Name = "ResponsibleColumn";
            // 
            // Priority
            // 
            this.Priority.HeaderText = "Priority";
            this.Priority.Name = "Priority";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.subTaskDataGrid);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
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
            this.panel2.Location = new System.Drawing.Point(0, 332);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 118);
            this.panel2.TabIndex = 4;
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
            this.CreateTaskButton.Location = new System.Drawing.Point(688, 0);
            this.CreateTaskButton.Name = "CreateTaskButton";
            this.CreateTaskButton.Size = new System.Drawing.Size(112, 118);
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
            this.priorityTask.Location = new System.Drawing.Point(289, 25);
            this.priorityTask.Name = "priorityTask";
            this.priorityTask.Size = new System.Drawing.Size(71, 21);
            this.priorityTask.TabIndex = 7;
            this.priorityTask.Text = "Priority:";
            // 
            // MaxTasksLabel
            // 
            this.MaxTasksLabel.AutoSize = true;
            this.MaxTasksLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MaxTasksLabel.Location = new System.Drawing.Point(271, 74);
            this.MaxTasksLabel.Name = "MaxTasksLabel";
            this.MaxTasksLabel.Size = new System.Drawing.Size(89, 21);
            this.MaxTasksLabel.TabIndex = 6;
            this.MaxTasksLabel.Text = "Max tasks:";
            // 
            // priorityCombo
            // 
            this.priorityCombo.FormattingEnabled = true;
            this.priorityCombo.Items.AddRange(new object[] {
            "Epic",
            "Bug",
            "Task",
            "Story"});
            this.priorityCombo.Location = new System.Drawing.Point(376, 22);
            this.priorityCombo.Name = "priorityCombo";
            this.priorityCombo.Size = new System.Drawing.Size(100, 23);
            this.priorityCombo.TabIndex = 5;
            this.priorityCombo.SelectedIndexChanged += new System.EventHandler(this.priorityCombo_SelectedIndexChanged);
            // 
            // maxTasksTxtbox
            // 
            this.maxTasksTxtbox.Location = new System.Drawing.Point(376, 72);
            this.maxTasksTxtbox.Name = "maxTasksTxtbox";
            this.maxTasksTxtbox.Size = new System.Drawing.Size(100, 23);
            this.maxTasksTxtbox.TabIndex = 4;
            this.maxTasksTxtbox.TextChanged += new System.EventHandler(this.maxTasksTxtbox_TextChanged);
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.StatusLabel.Location = new System.Drawing.Point(32, 25);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(124, 21);
            this.StatusLabel.TabIndex = 3;
            this.StatusLabel.Text = "StatusSubTask:";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NameLabel.Location = new System.Drawing.Point(32, 72);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(94, 21);
            this.NameLabel.TabIndex = 2;
            this.NameLabel.Text = "NameTask:";
            // 
            // statusCombo
            // 
            this.statusCombo.FormattingEnabled = true;
            this.statusCombo.Items.AddRange(new object[] {
            "InProgress",
            "Finished",
            "Opened"});
            this.statusCombo.Location = new System.Drawing.Point(171, 22);
            this.statusCombo.Name = "statusCombo";
            this.statusCombo.Size = new System.Drawing.Size(100, 23);
            this.statusCombo.TabIndex = 1;
            this.statusCombo.SelectedIndexChanged += new System.EventHandler(this.statusCombo_SelectedIndexChanged);
            // 
            // nameTxtBox
            // 
            this.nameTxtBox.Location = new System.Drawing.Point(147, 72);
            this.nameTxtBox.Name = "nameTxtBox";
            this.nameTxtBox.Size = new System.Drawing.Size(100, 23);
            this.nameTxtBox.TabIndex = 0;
            this.nameTxtBox.TextChanged += new System.EventHandler(this.nameTxtBox_TextChanged);
            // 
            // responsibleLabel
            // 
            this.responsibleLabel.AutoSize = true;
            this.responsibleLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.responsibleLabel.Location = new System.Drawing.Point(511, 20);
            this.responsibleLabel.Name = "responsibleLabel";
            this.responsibleLabel.Size = new System.Drawing.Size(106, 21);
            this.responsibleLabel.TabIndex = 10;
            this.responsibleLabel.Text = "Responsible:";
            // 
            // responsibleComboBox
            // 
            this.responsibleComboBox.FormattingEnabled = true;
            this.responsibleComboBox.Items.AddRange(new object[] {
            "Epic",
            "Bug",
            "Task",
            "Story"});
            this.responsibleComboBox.Location = new System.Drawing.Point(511, 51);
            this.responsibleComboBox.Name = "responsibleComboBox";
            this.responsibleComboBox.Size = new System.Drawing.Size(100, 23);
            this.responsibleComboBox.TabIndex = 9;
            this.responsibleComboBox.SelectedIndexChanged += new System.EventHandler(this.responsibleComboBox_SelectedIndexChanged);
            // 
            // ManageSubTasksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ManageSubTasksForm";
            this.Text = "ManageSubTasks";
            this.Load += new System.EventHandler(this.ManageSubTasks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.subTaskDataGrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView subTaskDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TitleColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreationDateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn StatusColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ResponsibleColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Priority;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button CreateTaskButton;
        private System.Windows.Forms.Label priorityTask;
        private System.Windows.Forms.Label MaxTasksLabel;
        private System.Windows.Forms.ComboBox priorityCombo;
        private System.Windows.Forms.TextBox maxTasksTxtbox;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.ComboBox statusCombo;
        private System.Windows.Forms.TextBox nameTxtBox;
        private System.Windows.Forms.Label responsibleLabel;
        private System.Windows.Forms.ComboBox responsibleComboBox;
    }
}