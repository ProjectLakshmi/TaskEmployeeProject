namespace Assignment_1
{
    partial class EmployeeTaskEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeTaskEdit));
            label1 = new Label();
            UpdatedTaskStatus = new ComboBox();
            SaveButton = new Button();
            CancelButton = new Button();
            UpdatedTextDiscription = new TextBox();
            TaskStatus = new Label();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Small", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(24, 17);
            label1.Name = "label1";
            label1.Size = new Size(140, 23);
            label1.TabIndex = 0;
            label1.Text = "Text Discription";
            label1.Click += label1_Click;
            // 
            // UpdatedTaskStatus
            // 
            UpdatedTaskStatus.BackColor = SystemColors.ButtonFace;
            UpdatedTaskStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            UpdatedTaskStatus.Font = new Font("Segoe UI", 12F);
            UpdatedTaskStatus.FormattingEnabled = true;
            UpdatedTaskStatus.Items.AddRange(new object[] { "Completed", "Not Completed" });
            UpdatedTaskStatus.Location = new Point(24, 114);
            UpdatedTaskStatus.Name = "UpdatedTaskStatus";
            UpdatedTaskStatus.Size = new Size(415, 29);
            UpdatedTaskStatus.TabIndex = 1;
            // 
            // SaveButton
            // 
            SaveButton.BackColor = Color.RoyalBlue;
            SaveButton.FlatAppearance.BorderSize = 0;
            SaveButton.FlatStyle = FlatStyle.Flat;
            SaveButton.Font = new Font("Sitka Small", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SaveButton.ForeColor = SystemColors.Window;
            SaveButton.Location = new Point(123, 177);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(75, 29);
            SaveButton.TabIndex = 2;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = false;
            SaveButton.Click += button1_Click;
            // 
            // CancelButton
            // 
            CancelButton.BackColor = Color.RoyalBlue;
            CancelButton.FlatAppearance.BorderSize = 0;
            CancelButton.FlatStyle = FlatStyle.Flat;
            CancelButton.Font = new Font("Sitka Small", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CancelButton.ForeColor = SystemColors.Window;
            CancelButton.Location = new Point(24, 177);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(75, 29);
            CancelButton.TabIndex = 3;
            CancelButton.Text = "Cancel";
            CancelButton.UseVisualStyleBackColor = false;
            CancelButton.Click += CancelButton_Click;
            // 
            // UpdatedTextDiscription
            // 
            UpdatedTextDiscription.BackColor = SystemColors.ButtonFace;
            UpdatedTextDiscription.BorderStyle = BorderStyle.FixedSingle;
            UpdatedTextDiscription.Font = new Font("Segoe UI", 12F);
            UpdatedTextDiscription.Location = new Point(24, 43);
            UpdatedTextDiscription.Name = "UpdatedTextDiscription";
            UpdatedTextDiscription.Size = new Size(415, 29);
            UpdatedTextDiscription.TabIndex = 4;
            // 
            // TaskStatus
            // 
            TaskStatus.AutoSize = true;
            TaskStatus.Font = new Font("Sitka Small", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TaskStatus.ForeColor = Color.Transparent;
            TaskStatus.Location = new Point(24, 88);
            TaskStatus.Name = "TaskStatus";
            TaskStatus.Size = new Size(102, 23);
            TaskStatus.TabIndex = 5;
            TaskStatus.Text = "Task Status";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(TaskStatus);
            panel1.Controls.Add(UpdatedTextDiscription);
            panel1.Controls.Add(CancelButton);
            panel1.Controls.Add(SaveButton);
            panel1.Controls.Add(UpdatedTaskStatus);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(699, 329);
            panel1.TabIndex = 6;
            panel1.Paint += panel1_Paint;
            // 
            // EmployeeTaskEdit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(699, 329);
            Controls.Add(panel1);
            Name = "EmployeeTaskEdit";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EmployeeTaskEdit";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private ComboBox UpdatedTaskStatus;
        private Button SaveButton;
        private Button CancelButton;
        private TextBox UpdatedTextDiscription;
        private Label TaskStatus;
        private Panel panel1;
    }
}