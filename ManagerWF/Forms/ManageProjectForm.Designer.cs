
using System.ComponentModel;
using System.Windows.Forms;

namespace ManagerWF.Forms
{
    partial class ManageProject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageProject));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.deleteButton = new System.Windows.Forms.Button();
            this.projectsButton = new System.Windows.Forms.Button();
            this.projectDataGrid = new System.Windows.Forms.DataGridView();
            this.IDColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TitleColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreationDateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ResponsibleColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubTask = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.responsibleName = new System.Windows.Forms.Label();
            this.responsibleComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.addSubTaskCombo = new System.Windows.Forms.ComboBox();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.statusCombo = new System.Windows.Forms.ComboBox();
            this.nameTxtBox = new System.Windows.Forms.TextBox();
            this.CreateTaskButton = new System.Windows.Forms.Button();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.projectDataGrid)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelMenu.Controls.Add(this.deleteButton);
            this.panelMenu.Controls.Add(this.projectsButton);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(144, 442);
            this.panelMenu.TabIndex = 4;
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
            this.deleteButton.Size = new System.Drawing.Size(144, 60);
            this.deleteButton.TabIndex = 3;
            this.deleteButton.Text = "  Delete Project";
            this.deleteButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.buttonDelete_Click);
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
            this.projectsButton.Size = new System.Drawing.Size(144, 60);
            this.projectsButton.TabIndex = 2;
            this.projectsButton.Text = "  Info Project";
            this.projectsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.projectsButton.UseVisualStyleBackColor = true;
            // 
            // projectDataGrid
            // 
            this.projectDataGrid.AllowUserToAddRows = false;
            this.projectDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.projectDataGrid.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.projectDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.projectDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDColumn,
            this.TitleColumn,
            this.CreationDateColumn,
            this.StatusColumn,
            this.ResponsibleColumn,
            this.SubTask});
            this.projectDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.projectDataGrid.Location = new System.Drawing.Point(144, 0);
            this.projectDataGrid.Name = "projectDataGrid";
            this.projectDataGrid.ReadOnly = true;
            this.projectDataGrid.RowTemplate.Height = 25;
            this.projectDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.projectDataGrid.Size = new System.Drawing.Size(812, 442);
            this.projectDataGrid.TabIndex = 5;
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
            // SubTask
            // 
            this.SubTask.HeaderText = "SubTasks";
            this.SubTask.Name = "SubTask";
            this.SubTask.ReadOnly = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(148)))), ((int)(((byte)(188)))));
            this.panel2.Controls.Add(this.responsibleName);
            this.panel2.Controls.Add(this.responsibleComboBox);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.addSubTaskCombo);
            this.panel2.Controls.Add(this.StatusLabel);
            this.panel2.Controls.Add(this.titleLabel);
            this.panel2.Controls.Add(this.statusCombo);
            this.panel2.Controls.Add(this.nameTxtBox);
            this.panel2.Controls.Add(this.CreateTaskButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(144, 325);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(812, 117);
            this.panel2.TabIndex = 6;
            // 
            // responsibleName
            // 
            this.responsibleName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.responsibleName.AutoSize = true;
            this.responsibleName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.responsibleName.Location = new System.Drawing.Point(358, 24);
            this.responsibleName.Name = "responsibleName";
            this.responsibleName.Size = new System.Drawing.Size(106, 21);
            this.responsibleName.TabIndex = 16;
            this.responsibleName.Text = "Responsible:";
            // 
            // responsibleComboBox
            // 
            this.responsibleComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.responsibleComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.responsibleComboBox.FormattingEnabled = true;
            this.responsibleComboBox.Location = new System.Drawing.Point(470, 22);
            this.responsibleComboBox.Name = "responsibleComboBox";
            this.responsibleComboBox.Size = new System.Drawing.Size(109, 23);
            this.responsibleComboBox.TabIndex = 15;
            this.responsibleComboBox.SelectedIndexChanged += new System.EventHandler(this.responsibleComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(327, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 21);
            this.label1.TabIndex = 14;
            this.label1.Text = "Add Sub-Task";
            // 
            // addSubTaskCombo
            // 
            this.addSubTaskCombo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addSubTaskCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.addSubTaskCombo.FormattingEnabled = true;
            this.addSubTaskCombo.Location = new System.Drawing.Point(452, 62);
            this.addSubTaskCombo.Name = "addSubTaskCombo";
            this.addSubTaskCombo.Size = new System.Drawing.Size(109, 23);
            this.addSubTaskCombo.TabIndex = 13;
            this.addSubTaskCombo.SelectedIndexChanged += new System.EventHandler(this.addSubTaskCombo_SelectedIndexChanged);
            // 
            // StatusLabel
            // 
            this.StatusLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.StatusLabel.Location = new System.Drawing.Point(99, 20);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(119, 21);
            this.StatusLabel.TabIndex = 12;
            this.StatusLabel.Text = "Project Status:";
            // 
            // titleLabel
            // 
            this.titleLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.titleLabel.Location = new System.Drawing.Point(138, 60);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(48, 21);
            this.titleLabel.TabIndex = 11;
            this.titleLabel.Text = "Title:";
            // 
            // statusCombo
            // 
            this.statusCombo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.statusCombo.AutoCompleteCustomSource.AddRange(new string[] {
            "InProgress",
            "Closed",
            "Opened"});
            this.statusCombo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.statusCombo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.statusCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.statusCombo.FormattingEnabled = true;
            this.statusCombo.Items.AddRange(new object[] {
            "InProgress",
            "Finished",
            "Opened"});
            this.statusCombo.Location = new System.Drawing.Point(224, 22);
            this.statusCombo.Name = "statusCombo";
            this.statusCombo.Size = new System.Drawing.Size(109, 23);
            this.statusCombo.TabIndex = 10;
            this.statusCombo.SelectedIndexChanged += new System.EventHandler(this.statusCombo_SelectedIndexChanged);
            // 
            // nameTxtBox
            // 
            this.nameTxtBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nameTxtBox.Location = new System.Drawing.Point(205, 62);
            this.nameTxtBox.Name = "nameTxtBox";
            this.nameTxtBox.PlaceholderText = "Type here";
            this.nameTxtBox.Size = new System.Drawing.Size(100, 23);
            this.nameTxtBox.TabIndex = 9;
            this.nameTxtBox.TextChanged += new System.EventHandler(this.nameTxtBox_TextChanged);
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
            this.CreateTaskButton.Location = new System.Drawing.Point(700, 0);
            this.CreateTaskButton.Name = "CreateTaskButton";
            this.CreateTaskButton.Size = new System.Drawing.Size(112, 117);
            this.CreateTaskButton.TabIndex = 8;
            this.CreateTaskButton.Text = "Create Task";
            this.CreateTaskButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.CreateTaskButton.UseVisualStyleBackColor = false;
            this.CreateTaskButton.Click += new System.EventHandler(this.CreateTaskButton_Click);
            // 
            // ManageProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 442);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.projectDataGrid);
            this.Controls.Add(this.panelMenu);
            this.Name = "ManageProject";
            this.Text = "ManageProject";
            this.Load += new System.EventHandler(this.ManageProject_Load);
            this.panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.projectDataGrid)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelMenu;
        private Button projectsButton;
        private DataGridView projectDataGrid;
        private Panel panel2;
        private Label StatusLabel;
        private Label titleLabel;
        private ComboBox statusCombo;
        private TextBox nameTxtBox;
        private Button CreateTaskButton;
        private Label label1;
        private ComboBox addSubTaskCombo;
        private Label responsibleName;
        private ComboBox responsibleComboBox;
        private DataGridViewTextBoxColumn IDColumn;
        private DataGridViewTextBoxColumn TitleColumn;
        private DataGridViewTextBoxColumn CreationDateColumn;
        private DataGridViewTextBoxColumn StatusColumn;
        private DataGridViewTextBoxColumn ResponsibleColumn;
        private DataGridViewTextBoxColumn SubTask;
        private Button deleteButton;
    }
}