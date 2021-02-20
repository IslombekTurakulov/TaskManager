
namespace ManagerWF.Forms
{
    partial class AddProject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddProject));
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CreateTaskButton = new System.Windows.Forms.Button();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.statusCombo = new System.Windows.Forms.ComboBox();
            this.nameTxtBox = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 343);
            this.panel2.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(43, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(745, 343);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.panel1.Controls.Add(this.CreateTaskButton);
            this.panel1.Controls.Add(this.StatusLabel);
            this.panel1.Controls.Add(this.NameLabel);
            this.panel1.Controls.Add(this.statusCombo);
            this.panel1.Controls.Add(this.nameTxtBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 343);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 107);
            this.panel1.TabIndex = 2;
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
            this.CreateTaskButton.Text = "Create Project";
            this.CreateTaskButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.CreateTaskButton.UseVisualStyleBackColor = false;
            this.CreateTaskButton.Click += new System.EventHandler(this.CreateTaskButton_Click);
            // 
            // StatusLabel
            // 
            this.StatusLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.StatusLabel.Location = new System.Drawing.Point(68, 19);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(154, 28);
            this.StatusLabel.TabIndex = 3;
            this.StatusLabel.Text = "StatusSubTask:";
            // 
            // NameLabel
            // 
            this.NameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NameLabel.Location = new System.Drawing.Point(360, 19);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(116, 28);
            this.NameLabel.TabIndex = 2;
            this.NameLabel.Text = "NameTask:";
            // 
            // statusCombo
            // 
            this.statusCombo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.statusCombo.AutoCompleteCustomSource.AddRange(new string[] {
            "InProgress",
            "Closed",
            "Opened"});
            this.statusCombo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.statusCombo.FormattingEnabled = true;
            this.statusCombo.Items.AddRange(new object[] {
            "InProgress",
            "Closed",
            "Opened"});
            this.statusCombo.Location = new System.Drawing.Point(237, 24);
            this.statusCombo.Name = "statusCombo";
            this.statusCombo.Size = new System.Drawing.Size(100, 23);
            this.statusCombo.TabIndex = 1;
            this.statusCombo.SelectedIndexChanged += new System.EventHandler(this.statusCombo_SelectedIndexChanged);
            // 
            // nameTxtBox
            // 
            this.nameTxtBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nameTxtBox.Location = new System.Drawing.Point(482, 24);
            this.nameTxtBox.Name = "nameTxtBox";
            this.nameTxtBox.Size = new System.Drawing.Size(100, 23);
            this.nameTxtBox.TabIndex = 0;
            this.nameTxtBox.TextChanged += new System.EventHandler(this.nameTxtBox_TextChanged);
            // 
            // AddProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "AddProject";
            this.Text = "AddProject";
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button CreateTaskButton;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.ComboBox statusCombo;
        private System.Windows.Forms.TextBox nameTxtBox;
    }
}