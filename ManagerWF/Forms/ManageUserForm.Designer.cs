﻿
using System.ComponentModel;
using System.Windows.Forms;

namespace ManagerWF.Forms
{
    partial class ManageUserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageUserForm));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.deleteButton = new System.Windows.Forms.Button();
            this.projectsButton = new System.Windows.Forms.Button();
            this.manageUserPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.userDataGrid = new System.Windows.Forms.DataGridView();
            this.IDColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creationDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelUserInput = new System.Windows.Forms.Panel();
            this.CreateTaskButton = new System.Windows.Forms.Button();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.userLabel = new System.Windows.Forms.Label();
            this.panelMenu.SuspendLayout();
            this.manageUserPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userDataGrid)).BeginInit();
            this.panelUserInput.SuspendLayout();
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
            this.panelMenu.Size = new System.Drawing.Size(149, 424);
            this.panelMenu.TabIndex = 1;
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
            this.deleteButton.Size = new System.Drawing.Size(149, 60);
            this.deleteButton.TabIndex = 5;
            this.deleteButton.Text = "  Delete User";
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
            this.projectsButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.projectsButton.Image = ((System.Drawing.Image)(resources.GetObject("projectsButton.Image")));
            this.projectsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.projectsButton.Location = new System.Drawing.Point(0, 0);
            this.projectsButton.Name = "projectsButton";
            this.projectsButton.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.projectsButton.Size = new System.Drawing.Size(149, 60);
            this.projectsButton.TabIndex = 2;
            this.projectsButton.Text = "  Manage Users";
            this.projectsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.projectsButton.UseVisualStyleBackColor = true;
            // 
            // manageUserPanel
            // 
            this.manageUserPanel.Controls.Add(this.panel1);
            this.manageUserPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.manageUserPanel.Location = new System.Drawing.Point(149, 0);
            this.manageUserPanel.Name = "manageUserPanel";
            this.manageUserPanel.Size = new System.Drawing.Size(791, 424);
            this.manageUserPanel.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(791, 424);
            this.panel1.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.userDataGrid);
            this.panel3.Controls.Add(this.panelUserInput);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(791, 424);
            this.panel3.TabIndex = 5;
            // 
            // userDataGrid
            // 
            this.userDataGrid.AllowUserToAddRows = false;
            this.userDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.userDataGrid.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.userDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDColumn,
            this.nameColumn,
            this.creationDate});
            this.userDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userDataGrid.Location = new System.Drawing.Point(0, 0);
            this.userDataGrid.Name = "userDataGrid";
            this.userDataGrid.ReadOnly = true;
            this.userDataGrid.RowTemplate.Height = 25;
            this.userDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.userDataGrid.Size = new System.Drawing.Size(791, 329);
            this.userDataGrid.TabIndex = 2;
            // 
            // IDColumn
            // 
            this.IDColumn.HeaderText = "ID";
            this.IDColumn.Name = "IDColumn";
            this.IDColumn.ReadOnly = true;
            // 
            // nameColumn
            // 
            this.nameColumn.HeaderText = "NameProject";
            this.nameColumn.Name = "nameColumn";
            this.nameColumn.ReadOnly = true;
            // 
            // creationDate
            // 
            this.creationDate.HeaderText = "Creation Date";
            this.creationDate.Name = "creationDate";
            this.creationDate.ReadOnly = true;
            // 
            // panelUserInput
            // 
            this.panelUserInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(148)))), ((int)(((byte)(188)))));
            this.panelUserInput.Controls.Add(this.CreateTaskButton);
            this.panelUserInput.Controls.Add(this.nameTextBox);
            this.panelUserInput.Controls.Add(this.userLabel);
            this.panelUserInput.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelUserInput.Location = new System.Drawing.Point(0, 329);
            this.panelUserInput.Name = "panelUserInput";
            this.panelUserInput.Size = new System.Drawing.Size(791, 95);
            this.panelUserInput.TabIndex = 3;
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
            this.CreateTaskButton.Location = new System.Drawing.Point(679, 0);
            this.CreateTaskButton.Name = "CreateTaskButton";
            this.CreateTaskButton.Size = new System.Drawing.Size(112, 95);
            this.CreateTaskButton.TabIndex = 9;
            this.CreateTaskButton.Text = "Create User";
            this.CreateTaskButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.CreateTaskButton.UseVisualStyleBackColor = false;
            this.CreateTaskButton.Click += new System.EventHandler(this.CreateTaskButton_Click);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(171, 39);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.PlaceholderText = "Type here";
            this.nameTextBox.Size = new System.Drawing.Size(119, 23);
            this.nameTextBox.TabIndex = 1;
            this.nameTextBox.TextChanged += new System.EventHandler(this.nameTextBox_TextChanged);
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.userLabel.Location = new System.Drawing.Point(40, 35);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(112, 28);
            this.userLabel.TabIndex = 0;
            this.userLabel.Text = "Name User:";
            // 
            // ManageUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 424);
            this.Controls.Add(this.manageUserPanel);
            this.Controls.Add(this.panelMenu);
            this.Name = "ManageUserForm";
            this.Text = "AddUser";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ManageUserForm_FormClosing);
            this.Load += new System.EventHandler(this.AddUser_Load);
            this.panelMenu.ResumeLayout(false);
            this.manageUserPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.userDataGrid)).EndInit();
            this.panelUserInput.ResumeLayout(false);
            this.panelUserInput.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelMenu;
        private Button projectsButton;
        private Panel manageUserPanel;
        private Panel panel1;
        private Panel panel3;
        private DataGridView userDataGrid;
        private Panel panelUserInput;
        private TextBox nameTextBox;
        private Label userLabel;
        private DataGridViewTextBoxColumn IDColumn;
        private DataGridViewTextBoxColumn nameColumn;
        private DataGridViewTextBoxColumn creationDate;
        private Button CreateTaskButton;
        private Button deleteButton;
    }
}