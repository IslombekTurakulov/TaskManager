
namespace ManagerWF.Forms
{
    partial class SubTaskForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SubTaskForm));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.projectsButton = new System.Windows.Forms.Button();
            this.subTaskPanel = new System.Windows.Forms.Panel();
            this.subTask = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.subTaskPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelMenu.Controls.Add(this.projectsButton);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(140, 450);
            this.panelMenu.TabIndex = 3;
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
            this.projectsButton.Click += new System.EventHandler(this.projectsButton_Click);
            // 
            // subTaskPanel
            // 
            this.subTaskPanel.Controls.Add(this.subTask);
            this.subTaskPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.subTaskPanel.Location = new System.Drawing.Point(140, 0);
            this.subTaskPanel.Name = "subTaskPanel";
            this.subTaskPanel.Size = new System.Drawing.Size(660, 450);
            this.subTaskPanel.TabIndex = 5;
            // 
            // subTask
            // 
            this.subTask.Dock = System.Windows.Forms.DockStyle.Fill;
            this.subTask.Location = new System.Drawing.Point(0, 0);
            this.subTask.Name = "subTask";
            this.subTask.Size = new System.Drawing.Size(660, 450);
            this.subTask.TabIndex = 2;
            // 
            // SubTaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.subTaskPanel);
            this.Controls.Add(this.panelMenu);
            this.Name = "SubTaskForm";
            this.Text = "SubTask";
            this.panelMenu.ResumeLayout(false);
            this.subTaskPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button projectsButton;
        private System.Windows.Forms.Panel subTaskPanel;
        private System.Windows.Forms.Panel subTask;
    }
}