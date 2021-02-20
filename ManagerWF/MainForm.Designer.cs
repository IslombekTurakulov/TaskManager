﻿
namespace ManagerWF
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.aboutButton = new System.Windows.Forms.Button();
            this.addUserButton = new System.Windows.Forms.Button();
            this.projectsButton = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.closeChildForm = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.logoPicture = new System.Windows.Forms.PictureBox();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            this.panelDesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelMenu.Controls.Add(this.button1);
            this.panelMenu.Controls.Add(this.aboutButton);
            this.panelMenu.Controls.Add(this.addUserButton);
            this.panelMenu.Controls.Add(this.projectsButton);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.ForeColor = System.Drawing.Color.White;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(165, 450);
            this.panelMenu.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Linen;
            this.button1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(0, 377);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(165, 73);
            this.button1.TabIndex = 5;
            this.button1.Text = "  Exit";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // aboutButton
            // 
            this.aboutButton.BackColor = System.Drawing.Color.Linen;
            this.aboutButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.aboutButton.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.aboutButton.FlatAppearance.BorderSize = 0;
            this.aboutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aboutButton.ForeColor = System.Drawing.Color.Black;
            this.aboutButton.Image = ((System.Drawing.Image)(resources.GetObject("aboutButton.Image")));
            this.aboutButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.aboutButton.Location = new System.Drawing.Point(0, 180);
            this.aboutButton.Name = "aboutButton";
            this.aboutButton.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.aboutButton.Size = new System.Drawing.Size(165, 52);
            this.aboutButton.TabIndex = 4;
            this.aboutButton.Text = "  About";
            this.aboutButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.aboutButton.UseVisualStyleBackColor = false;
            this.aboutButton.Click += new System.EventHandler(this.aboutButton_Click);
            // 
            // addUserButton
            // 
            this.addUserButton.BackColor = System.Drawing.Color.Linen;
            this.addUserButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.addUserButton.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.addUserButton.FlatAppearance.BorderSize = 0;
            this.addUserButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addUserButton.ForeColor = System.Drawing.Color.Black;
            this.addUserButton.Image = ((System.Drawing.Image)(resources.GetObject("addUserButton.Image")));
            this.addUserButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addUserButton.Location = new System.Drawing.Point(0, 120);
            this.addUserButton.Name = "addUserButton";
            this.addUserButton.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.addUserButton.Size = new System.Drawing.Size(165, 60);
            this.addUserButton.TabIndex = 3;
            this.addUserButton.Text = " Manage User";
            this.addUserButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.addUserButton.UseVisualStyleBackColor = false;
            this.addUserButton.Click += new System.EventHandler(this.addUserButton_Click);
            // 
            // projectsButton
            // 
            this.projectsButton.BackColor = System.Drawing.Color.Linen;
            this.projectsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.projectsButton.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.projectsButton.FlatAppearance.BorderSize = 0;
            this.projectsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.projectsButton.ForeColor = System.Drawing.Color.Black;
            this.projectsButton.Image = ((System.Drawing.Image)(resources.GetObject("projectsButton.Image")));
            this.projectsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.projectsButton.Location = new System.Drawing.Point(0, 60);
            this.projectsButton.Name = "projectsButton";
            this.projectsButton.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.projectsButton.Size = new System.Drawing.Size(165, 60);
            this.projectsButton.TabIndex = 2;
            this.projectsButton.Text = "  Manage Projects";
            this.projectsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.projectsButton.UseVisualStyleBackColor = false;
            this.projectsButton.Click += new System.EventHandler(this.projectsButton_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panelLogo.Controls.Add(this.label1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(165, 60);
            this.panelLogo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manager Peergrade";
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelTitleBar.Controls.Add(this.closeChildForm);
            this.panelTitleBar.Controls.Add(this.labelTitle);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(165, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(635, 60);
            this.panelTitleBar.TabIndex = 1;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // closeChildForm
            // 
            this.closeChildForm.Dock = System.Windows.Forms.DockStyle.Left;
            this.closeChildForm.FlatAppearance.BorderSize = 0;
            this.closeChildForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeChildForm.Image = ((System.Drawing.Image)(resources.GetObject("closeChildForm.Image")));
            this.closeChildForm.Location = new System.Drawing.Point(0, 0);
            this.closeChildForm.Name = "closeChildForm";
            this.closeChildForm.Size = new System.Drawing.Size(75, 60);
            this.closeChildForm.TabIndex = 1;
            this.closeChildForm.UseVisualStyleBackColor = true;
            this.closeChildForm.Click += new System.EventHandler(this.closeChildForm_Click_1);
            // 
            // labelTitle
            // 
            this.labelTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTitle.AutoSize = true;
            this.labelTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTitle.ForeColor = System.Drawing.Color.White;
            this.labelTitle.Location = new System.Drawing.Point(301, 11);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(73, 30);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Home";
            // 
            // panelDesktop
            // 
            this.panelDesktop.Controls.Add(this.logoPicture);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(165, 60);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(635, 390);
            this.panelDesktop.TabIndex = 2;
            // 
            // logoPicture
            // 
            this.logoPicture.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.logoPicture.Image = ((System.Drawing.Image)(resources.GetObject("logoPicture.Image")));
            this.logoPicture.Location = new System.Drawing.Point(-9, 0);
            this.logoPicture.Name = "logoPicture";
            this.logoPicture.Size = new System.Drawing.Size(700, 400);
            this.logoPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.logoPicture.TabIndex = 0;
            this.logoPicture.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.MinimumSize = new System.Drawing.Size(816, 488);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.panelDesktop.ResumeLayout(false);
            this.panelDesktop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button aboutButton;
        private System.Windows.Forms.Button addUserButton;
        private System.Windows.Forms.Button projectsButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.PictureBox logoPicture;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button closeChildForm;
    }
}
