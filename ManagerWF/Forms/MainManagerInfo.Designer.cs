
using System.ComponentModel;
using System.Windows.Forms;

namespace ManagerWF.Forms
{
    partial class MainManagerInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainManagerInfo));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.manageTasks = new System.Windows.Forms.Button();
            this.projectsButton = new System.Windows.Forms.Button();
            this.managePanel = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelMenu.Controls.Add(this.button1);
            this.panelMenu.Controls.Add(this.manageTasks);
            this.panelMenu.Controls.Add(this.projectsButton);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(145, 450);
            this.panelMenu.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Gainsboro;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(0, 390);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(145, 60);
            this.button1.TabIndex = 5;
            this.button1.Text = "  Info";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // manageTasks
            // 
            this.manageTasks.Dock = System.Windows.Forms.DockStyle.Top;
            this.manageTasks.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.manageTasks.FlatAppearance.BorderSize = 0;
            this.manageTasks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.manageTasks.ForeColor = System.Drawing.Color.Gainsboro;
            this.manageTasks.Image = ((System.Drawing.Image)(resources.GetObject("manageTasks.Image")));
            this.manageTasks.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.manageTasks.Location = new System.Drawing.Point(0, 60);
            this.manageTasks.Name = "manageTasks";
            this.manageTasks.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.manageTasks.Size = new System.Drawing.Size(145, 60);
            this.manageTasks.TabIndex = 3;
            this.manageTasks.Text = " Manage Sub-Tasks";
            this.manageTasks.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.manageTasks.UseVisualStyleBackColor = true;
            this.manageTasks.Click += new System.EventHandler(this.manageTasks_Click);
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
            this.projectsButton.Size = new System.Drawing.Size(145, 60);
            this.projectsButton.TabIndex = 2;
            this.projectsButton.Text = "  Manage Project";
            this.projectsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.projectsButton.UseVisualStyleBackColor = true;
            this.projectsButton.Click += new System.EventHandler(this.projectsButton_Click);
            // 
            // managePanel
            // 
            this.managePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.managePanel.Location = new System.Drawing.Point(145, 0);
            this.managePanel.Name = "managePanel";
            this.managePanel.Size = new System.Drawing.Size(655, 450);
            this.managePanel.TabIndex = 3;
            // 
            // Project
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.managePanel);
            this.Controls.Add(this.panelMenu);
            this.Name = "Project";
            this.Text = "Project";
            this.Load += new System.EventHandler(this.Project_Load);
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelMenu;
        private Button manageTasks;
        private Button projectsButton;
        private Button button1;
        private Panel managePanel;
    }
}