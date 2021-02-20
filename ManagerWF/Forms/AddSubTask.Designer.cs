
namespace ManagerWF.Forms
{
    partial class AddSubTask
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddSubTask));
            this.panel1 = new System.Windows.Forms.Panel();
            this.CreateTaskButton = new System.Windows.Forms.Button();
            this.priorityTask = new System.Windows.Forms.Label();
            this.MaxTasksLabel = new System.Windows.Forms.Label();
            this.priorityCombo = new System.Windows.Forms.ComboBox();
            this.maxTasksTxtbox = new System.Windows.Forms.TextBox();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.statusCombo = new System.Windows.Forms.ComboBox();
            this.nameTxtBox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.panel1.Controls.Add(this.CreateTaskButton);
            this.panel1.Controls.Add(this.priorityTask);
            this.panel1.Controls.Add(this.MaxTasksLabel);
            this.panel1.Controls.Add(this.priorityCombo);
            this.panel1.Controls.Add(this.maxTasksTxtbox);
            this.panel1.Controls.Add(this.StatusLabel);
            this.panel1.Controls.Add(this.NameLabel);
            this.panel1.Controls.Add(this.statusCombo);
            this.panel1.Controls.Add(this.nameTxtBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 343);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 107);
            this.panel1.TabIndex = 0;
            // 
            // CreateTaskButton
            // 
            this.CreateTaskButton.BackColor = System.Drawing.Color.Transparent;
            this.CreateTaskButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.CreateTaskButton.FlatAppearance.BorderSize = 0;
            this.CreateTaskButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateTaskButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CreateTaskButton.Image = ((System.Drawing.Image)(resources.GetObject("CreateTaskButton.Image")));
            this.CreateTaskButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CreateTaskButton.Location = new System.Drawing.Point(688, 0);
            this.CreateTaskButton.Name = "CreateTaskButton";
            this.CreateTaskButton.Size = new System.Drawing.Size(112, 107);
            this.CreateTaskButton.TabIndex = 8;
            this.CreateTaskButton.Text = "Create Task";
            this.CreateTaskButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.CreateTaskButton.UseVisualStyleBackColor = false;
            this.CreateTaskButton.Click += new System.EventHandler(this.CreateTaskButton_Click);
            // 
            // priorityTask
            // 
            this.priorityTask.AutoSize = true;
            this.priorityTask.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.priorityTask.Location = new System.Drawing.Point(390, 21);
            this.priorityTask.Name = "priorityTask";
            this.priorityTask.Size = new System.Drawing.Size(88, 28);
            this.priorityTask.TabIndex = 7;
            this.priorityTask.Text = "Priority:";
            // 
            // MaxTasksLabel
            // 
            this.MaxTasksLabel.AutoSize = true;
            this.MaxTasksLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MaxTasksLabel.Location = new System.Drawing.Point(366, 72);
            this.MaxTasksLabel.Name = "MaxTasksLabel";
            this.MaxTasksLabel.Size = new System.Drawing.Size(112, 28);
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
            this.priorityCombo.Location = new System.Drawing.Point(484, 24);
            this.priorityCombo.Name = "priorityCombo";
            this.priorityCombo.Size = new System.Drawing.Size(100, 23);
            this.priorityCombo.TabIndex = 5;
            this.priorityCombo.SelectedIndexChanged += new System.EventHandler(this.priorityCombo_SelectedIndexChanged);
            // 
            // maxTasksTxtbox
            // 
            this.maxTasksTxtbox.Location = new System.Drawing.Point(484, 75);
            this.maxTasksTxtbox.Name = "maxTasksTxtbox";
            this.maxTasksTxtbox.Size = new System.Drawing.Size(100, 23);
            this.maxTasksTxtbox.TabIndex = 4;
            this.maxTasksTxtbox.TextChanged += new System.EventHandler(this.maxTasksTxtbox_TextChanged);
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.StatusLabel.Location = new System.Drawing.Point(90, 21);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(154, 28);
            this.StatusLabel.TabIndex = 3;
            this.StatusLabel.Text = "StatusSubTask:";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NameLabel.Location = new System.Drawing.Point(90, 72);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(116, 28);
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
            this.statusCombo.Location = new System.Drawing.Point(250, 24);
            this.statusCombo.Name = "statusCombo";
            this.statusCombo.Size = new System.Drawing.Size(100, 23);
            this.statusCombo.TabIndex = 1;
            this.statusCombo.SelectedIndexChanged += new System.EventHandler(this.statusCombo_SelectedIndexChanged);
            // 
            // nameTxtBox
            // 
            this.nameTxtBox.Location = new System.Drawing.Point(220, 74);
            this.nameTxtBox.Name = "nameTxtBox";
            this.nameTxtBox.Size = new System.Drawing.Size(100, 23);
            this.nameTxtBox.TabIndex = 0;
            this.nameTxtBox.TextChanged += new System.EventHandler(this.nameTxtBox_TextChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 343);
            this.panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(55, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(745, 343);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // AddSubTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "AddSubTask";
            this.Text = "AddSubTask";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox nameTxtBox;
        private System.Windows.Forms.Label priorityTask;
        private System.Windows.Forms.Label MaxTasksLabel;
        private System.Windows.Forms.ComboBox priorityCombo;
        private System.Windows.Forms.TextBox maxTasksTxtbox;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.ComboBox statusCombo;
        private System.Windows.Forms.Button CreateTaskButton;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}