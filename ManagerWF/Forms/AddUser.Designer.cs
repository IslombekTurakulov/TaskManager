
namespace ManagerWF.Forms
{
    partial class AddUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddUser));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.aboutButton = new System.Windows.Forms.Button();
            this.addUserButton = new System.Windows.Forms.Button();
            this.projectsButton = new System.Windows.Forms.Button();
            this.manageUserPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.IDColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TitleColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreationDateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ResponsibleColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelMenu.SuspendLayout();
            this.manageUserPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelMenu.Controls.Add(this.aboutButton);
            this.panelMenu.Controls.Add(this.addUserButton);
            this.panelMenu.Controls.Add(this.projectsButton);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(114, 450);
            this.panelMenu.TabIndex = 1;
            // 
            // aboutButton
            // 
            this.aboutButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.aboutButton.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.aboutButton.FlatAppearance.BorderSize = 0;
            this.aboutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aboutButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.aboutButton.Image = ((System.Drawing.Image)(resources.GetObject("aboutButton.Image")));
            this.aboutButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.aboutButton.Location = new System.Drawing.Point(0, 120);
            this.aboutButton.Name = "aboutButton";
            this.aboutButton.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.aboutButton.Size = new System.Drawing.Size(114, 60);
            this.aboutButton.TabIndex = 4;
            this.aboutButton.Text = "  Edit";
            this.aboutButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.aboutButton.UseVisualStyleBackColor = true;
            // 
            // addUserButton
            // 
            this.addUserButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.addUserButton.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.addUserButton.FlatAppearance.BorderSize = 0;
            this.addUserButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addUserButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.addUserButton.Image = ((System.Drawing.Image)(resources.GetObject("addUserButton.Image")));
            this.addUserButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addUserButton.Location = new System.Drawing.Point(0, 60);
            this.addUserButton.Name = "addUserButton";
            this.addUserButton.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.addUserButton.Size = new System.Drawing.Size(114, 60);
            this.addUserButton.TabIndex = 3;
            this.addUserButton.Text = " Add User";
            this.addUserButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.addUserButton.UseVisualStyleBackColor = true;
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
            this.projectsButton.Size = new System.Drawing.Size(114, 60);
            this.projectsButton.TabIndex = 2;
            this.projectsButton.Text = "  Manage Users";
            this.projectsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.projectsButton.UseVisualStyleBackColor = true;
            // 
            // manageUserPanel
            // 
            this.manageUserPanel.Controls.Add(this.panel1);
            this.manageUserPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.manageUserPanel.Location = new System.Drawing.Point(114, 0);
            this.manageUserPanel.Name = "manageUserPanel";
            this.manageUserPanel.Size = new System.Drawing.Size(686, 450);
            this.manageUserPanel.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(686, 450);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(686, 450);
            this.panel2.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDColumn,
            this.TitleColumn,
            this.CreationDateColumn,
            this.StatusColumn,
            this.ResponsibleColumn});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(686, 450);
            this.dataGridView1.TabIndex = 2;
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
            // AddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.manageUserPanel);
            this.Controls.Add(this.panelMenu);
            this.Name = "AddUser";
            this.Text = "AddUser";
            this.Load += new System.EventHandler(this.AddUser_Load);
            this.panelMenu.ResumeLayout(false);
            this.manageUserPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button aboutButton;
        private System.Windows.Forms.Button addUserButton;
        private System.Windows.Forms.Button projectsButton;
        private System.Windows.Forms.Panel manageUserPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TitleColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreationDateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn StatusColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ResponsibleColumn;
    }
}