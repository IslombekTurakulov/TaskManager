
namespace ManagerWF.Forms
{
    partial class ManageProject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageProject));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.manageTasks = new System.Windows.Forms.Button();
            this.projectsButton = new System.Windows.Forms.Button();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelMenu.Controls.Add(this.manageTasks);
            this.panelMenu.Controls.Add(this.projectsButton);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(135, 450);
            this.panelMenu.TabIndex = 4;
            // 
            // manageTasks
            // 
            this.manageTasks.Dock = System.Windows.Forms.DockStyle.Top;
            this.manageTasks.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.manageTasks.FlatAppearance.BorderSize = 0;
            this.manageTasks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.manageTasks.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.manageTasks.ForeColor = System.Drawing.Color.White;
            this.manageTasks.Image = ((System.Drawing.Image)(resources.GetObject("manageTasks.Image")));
            this.manageTasks.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.manageTasks.Location = new System.Drawing.Point(0, 60);
            this.manageTasks.Name = "manageTasks";
            this.manageTasks.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.manageTasks.Size = new System.Drawing.Size(135, 60);
            this.manageTasks.TabIndex = 3;
            this.manageTasks.Text = " Add Project";
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
            this.projectsButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.projectsButton.ForeColor = System.Drawing.Color.White;
            this.projectsButton.Image = ((System.Drawing.Image)(resources.GetObject("projectsButton.Image")));
            this.projectsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.projectsButton.Location = new System.Drawing.Point(0, 0);
            this.projectsButton.Name = "projectsButton";
            this.projectsButton.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.projectsButton.Size = new System.Drawing.Size(135, 60);
            this.projectsButton.TabIndex = 2;
            this.projectsButton.Text = "  Info Project";
            this.projectsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.projectsButton.UseVisualStyleBackColor = true;
            this.projectsButton.Click += new System.EventHandler(this.projectsButton_Click);
            // 
            // ManageProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelMenu);
            this.Name = "ManageProject";
            this.Text = "ManageProject";
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button manageTasks;
        private System.Windows.Forms.Button projectsButton;
    }
}