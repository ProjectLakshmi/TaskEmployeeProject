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
            label1 = new Label();
            UpdatedTaskStatus = new ComboBox();
            SaveButton = new Button();
            CancelButton = new Button();
            UpdatedTextDiscription = new TextBox();
            TaskStatus = new Label();
            panel1 = new Panel();
            label2 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(108, 117, 125);
            label1.Location = new Point(27, 84);
            label1.Name = "label1";
            label1.Size = new Size(145, 25);
            label1.TabIndex = 0;
            label1.Text = "Text Discription";
            // 
            // UpdatedTaskStatus
            // 
            UpdatedTaskStatus.BackColor = SystemColors.ButtonFace;
            UpdatedTaskStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            UpdatedTaskStatus.FlatStyle = FlatStyle.Flat;
            UpdatedTaskStatus.Font = new Font("Segoe UI", 12F);
            UpdatedTaskStatus.FormattingEnabled = true;
            UpdatedTaskStatus.Items.AddRange(new object[] { "Completed", "Not Completed" });
            UpdatedTaskStatus.Location = new Point(27, 224);
            UpdatedTaskStatus.Margin = new Padding(3, 4, 3, 4);
            UpdatedTaskStatus.Name = "UpdatedTaskStatus";
            UpdatedTaskStatus.Size = new Size(400, 36);
            UpdatedTaskStatus.TabIndex = 1;
            // 
            // SaveButton
            // 
            SaveButton.BackColor = Color.FromArgb(0, 123, 255);
            SaveButton.FlatAppearance.BorderSize = 0;
            SaveButton.FlatStyle = FlatStyle.Flat;
            SaveButton.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SaveButton.ForeColor = SystemColors.Window;
            SaveButton.Location = new Point(167, 306);
            SaveButton.Margin = new Padding(3, 4, 3, 4);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(120, 40);
            SaveButton.TabIndex = 2;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = false;
            SaveButton.Click += button1_Click;
            // 
            // CancelButton
            // 
            CancelButton.BackColor = Color.White;
            CancelButton.FlatAppearance.BorderColor = Color.Gray;
            CancelButton.FlatStyle = FlatStyle.Flat;
            CancelButton.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CancelButton.ForeColor = Color.Black;
            CancelButton.Location = new Point(27, 306);
            CancelButton.Margin = new Padding(3, 4, 3, 4);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(120, 40);
            CancelButton.TabIndex = 3;
            CancelButton.Text = "Cancel";
            CancelButton.UseVisualStyleBackColor = false;
            CancelButton.Click += CancelButton_Click;
            // 
            // UpdatedTextDiscription
            // 
            UpdatedTextDiscription.AcceptsReturn = true;
            UpdatedTextDiscription.BackColor = SystemColors.ButtonFace;
            UpdatedTextDiscription.BorderStyle = BorderStyle.FixedSingle;
            UpdatedTextDiscription.Font = new Font("Segoe UI", 12F);
            UpdatedTextDiscription.Location = new Point(27, 124);
            UpdatedTextDiscription.Margin = new Padding(3, 4, 3, 4);
            UpdatedTextDiscription.Multiline = true;
            UpdatedTextDiscription.Name = "UpdatedTextDiscription";
            UpdatedTextDiscription.ScrollBars = ScrollBars.Vertical;
            UpdatedTextDiscription.Size = new Size(400, 35);
            UpdatedTextDiscription.TabIndex = 4;
            // 
            // TaskStatus
            // 
            TaskStatus.AutoSize = true;
            TaskStatus.BackColor = Color.Transparent;
            TaskStatus.Font = new Font("Sitka Small", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TaskStatus.ForeColor = Color.FromArgb(108, 117, 125);
            TaskStatus.Location = new Point(27, 182);
            TaskStatus.Name = "TaskStatus";
            TaskStatus.Size = new Size(127, 28);
            TaskStatus.TabIndex = 5;
            TaskStatus.Text = "Task Status";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(TaskStatus);
            panel1.Controls.Add(UpdatedTextDiscription);
            panel1.Controls.Add(CancelButton);
            panel1.Controls.Add(SaveButton);
            panel1.Controls.Add(UpdatedTaskStatus);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(180, 61);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(489, 386);
            panel1.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(33, 37, 41);
            label2.Location = new Point(216, 21);
            label2.Name = "label2";
            label2.Size = new Size(108, 31);
            label2.TabIndex = 6;
            label2.Text = "Edit Task";
            // 
            // EmployeeTaskEdit
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 242, 245);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(817, 518);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "EmployeeTaskEdit";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EmployeeTaskEdit";
            Load += EmployeeTaskEdit_Load;
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
        private Label label2;
    }
}