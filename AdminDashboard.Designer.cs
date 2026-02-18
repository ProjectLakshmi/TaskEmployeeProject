namespace Assignment_1
{
    partial class AdminDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminDashboard));
            ViewEmployees = new Button();
            Status = new ComboBox();
            BackButton = new Button();
            panel1 = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            panel2 = new Panel();
            label3 = new Label();
            label1 = new Label();
            panel3 = new Panel();
            show_tasks = new Button();
            dataGridView1 = new DataGridView();
            Employee_ID = new DataGridViewTextBoxColumn();
            EmployeeName = new DataGridViewTextBoxColumn();
            dataGridView2 = new DataGridView();
            EmpId = new DataGridViewTextBoxColumn();
            TaskId = new DataGridViewTextBoxColumn();
            TaskDiscription = new DataGridViewTextBoxColumn();
            TaskStatus = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // ViewEmployees
            // 
            ViewEmployees.BackColor = SystemColors.MenuHighlight;
            ViewEmployees.Dock = DockStyle.Top;
            ViewEmployees.ForeColor = Color.Transparent;
            ViewEmployees.Location = new Point(0, 0);
            ViewEmployees.Name = "ViewEmployees";
            ViewEmployees.Size = new Size(469, 33);
            ViewEmployees.TabIndex = 3;
            ViewEmployees.Text = "View Employees";
            ViewEmployees.UseVisualStyleBackColor = false;
            ViewEmployees.Click += button1_Click;
            // 
            // Status
            // 
            Status.FormattingEnabled = true;
            Status.Items.AddRange(new object[] { "All", "Pending", "Completed" });
            Status.Location = new Point(3, 88);
            Status.Name = "Status";
            Status.Size = new Size(466, 33);
            Status.TabIndex = 6;
            Status.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // BackButton
            // 
            BackButton.BackColor = SystemColors.Highlight;
            BackButton.ForeColor = Color.Transparent;
            BackButton.Location = new Point(0, 73);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(78, 27);
            BackButton.TabIndex = 8;
            BackButton.Text = "Back";
            BackButton.UseVisualStyleBackColor = false;
            BackButton.Click += BackButton_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Window;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(165, 479);
            panel1.TabIndex = 9;
            // 
            // panel4
            // 
            panel4.Location = new Point(165, 67);
            panel4.Name = "panel4";
            panel4.Size = new Size(100, 33);
            panel4.TabIndex = 7;
            // 
            // panel5
            // 
            panel5.Location = new Point(165, 72);
            panel5.Name = "panel5";
            panel5.Size = new Size(466, 35);
            panel5.TabIndex = 8;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(BackButton);
            panel2.Controls.Add(label3);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 378);
            panel2.Name = "panel2";
            panel2.Size = new Size(165, 101);
            panel2.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.InfoText;
            label3.Location = new Point(3, 32);
            label3.Name = "label3";
            label3.Size = new Size(78, 28);
            label3.TabIndex = 1;
            label3.Text = "Logout";
            label3.Click += label3_Click;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.MenuText;
            label1.Location = new Point(0, 25);
            label1.Name = "label1";
            label1.Size = new Size(148, 21);
            label1.TabIndex = 0;
            label1.Text = "Admin DashBoard";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel3
            // 
            panel3.Controls.Add(show_tasks);
            panel3.Controls.Add(dataGridView1);
            panel3.Controls.Add(dataGridView2);
            panel3.Controls.Add(Status);
            panel3.Controls.Add(ViewEmployees);
            panel3.Location = new Point(165, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(469, 478);
            panel3.TabIndex = 11;
            // 
            // show_tasks
            // 
            show_tasks.BackColor = SystemColors.MenuHighlight;
            show_tasks.ForeColor = Color.Transparent;
            show_tasks.Location = new Point(0, 136);
            show_tasks.Name = "show_tasks";
            show_tasks.Size = new Size(108, 38);
            show_tasks.TabIndex = 7;
            show_tasks.Text = "Show Tasks";
            show_tasks.UseVisualStyleBackColor = false;
            show_tasks.Click += show_tasks_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Employee_ID, EmployeeName });
            dataGridView1.Location = new Point(0, 248);
            dataGridView1.Margin = new Padding(15, 3, 3, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(469, 230);
            dataGridView1.TabIndex = 4;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Employee_ID
            // 
            Employee_ID.DataPropertyName = "employee_id";
            Employee_ID.HeaderText = "Employee Id";
            Employee_ID.MinimumWidth = 6;
            Employee_ID.Name = "Employee_ID";
            Employee_ID.ReadOnly = true;
            // 
            // EmployeeName
            // 
            EmployeeName.DataPropertyName = "employee_name";
            EmployeeName.HeaderText = "Employee Name";
            EmployeeName.MinimumWidth = 6;
            EmployeeName.Name = "EmployeeName";
            EmployeeName.ReadOnly = true;
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToResizeRows = false;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView2.BackgroundColor = SystemColors.Window;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { EmpId, TaskId, TaskDiscription, TaskStatus });
            dataGridView2.Location = new Point(0, 248);
            dataGridView2.Margin = new Padding(3, 15, 3, 3);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersVisible = false;
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(469, 231);
            dataGridView2.TabIndex = 5;
            // 
            // EmpId
            // 
            EmpId.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            EmpId.DataPropertyName = "employee_id";
            EmpId.HeaderText = "Employee Id";
            EmpId.MinimumWidth = 6;
            EmpId.Name = "EmpId";
            EmpId.ReadOnly = true;
            EmpId.Visible = false;
            EmpId.Width = 125;
            // 
            // TaskId
            // 
            TaskId.DataPropertyName = "task_id";
            TaskId.HeaderText = "Task Id";
            TaskId.MinimumWidth = 6;
            TaskId.Name = "TaskId";
            TaskId.ReadOnly = true;
            // 
            // TaskDiscription
            // 
            TaskDiscription.DataPropertyName = "task_discription";
            TaskDiscription.HeaderText = "Task Discription";
            TaskDiscription.MinimumWidth = 6;
            TaskDiscription.Name = "TaskDiscription";
            TaskDiscription.ReadOnly = true;
            // 
            // TaskStatus
            // 
            TaskStatus.DataPropertyName = "task_status";
            TaskStatus.HeaderText = "Task Status";
            TaskStatus.MinimumWidth = 6;
            TaskStatus.Name = "TaskStatus";
            TaskStatus.ReadOnly = true;
            // 
            // AdminDashboard
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(638, 479);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            Name = "AdminDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin";
            Load += AdminDashboard_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button ViewEmployees;
        private ComboBox Status;
        private Button BackButton;
        private Panel panel1;
        private Label label3;
        private Label label1;
        private Panel panel3;
        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private Panel panel2;
        private Panel panel4;
        private Panel panel5;
        private Button show_tasks;
        private DataGridViewTextBoxColumn Employee_ID;
        private DataGridViewTextBoxColumn EmployeeName;
        private DataGridViewTextBoxColumn EmpId;
        private DataGridViewTextBoxColumn TaskId;
        private DataGridViewTextBoxColumn TaskDiscription;
        private DataGridViewTextBoxColumn TaskStatus;
    }
}