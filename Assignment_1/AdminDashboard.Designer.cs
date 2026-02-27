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
            ViewEmployees = new Button();
            Status = new ComboBox();
            BackButton = new Button();
            panel1 = new Panel();
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
            Status.DropDownStyle = ComboBoxStyle.DropDownList;
            Status.FormattingEnabled = true;
            Status.Items.AddRange(new object[] { "All", "Pending", "Completed" });
            Status.Location = new Point(0, 5);
            Status.Name = "Status";
            Status.Size = new Size(466, 28);
            Status.TabIndex = 6;
            Status.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // BackButton
            // 
            BackButton.BackColor = Color.FromArgb(33, 37, 41);
            BackButton.ForeColor = Color.Transparent;
            BackButton.Location = new Point(12, 62);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(78, 36);
            BackButton.TabIndex = 8;
            BackButton.Text = "Back";
            BackButton.UseVisualStyleBackColor = false;
            BackButton.Click += BackButton_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(33, 37, 41);
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(220, 395);
            panel1.TabIndex = 9;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(BackButton);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(0, 288);
            panel2.Name = "panel2";
            panel2.Size = new Size(217, 101);
            panel2.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(220, 53, 69);
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(12, 11);
            label3.Name = "label3";
            label3.Size = new Size(64, 21);
            label3.TabIndex = 1;
            label3.Text = "Logout";
            label3.Click += label3_Click;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 24);
            label1.Name = "label1";
            label1.Size = new Size(148, 30);
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
            panel3.Location = new Point(226, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(469, 389);
            panel3.TabIndex = 11;
            // 
            // show_tasks
            // 
            show_tasks.BackColor = SystemColors.MenuHighlight;
            show_tasks.ForeColor = Color.Transparent;
            show_tasks.Location = new Point(3, 89);
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
            dataGridView1.Location = new Point(0, 162);
            dataGridView1.Margin = new Padding(15, 3, 3, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(469, 227);
            dataGridView1.TabIndex = 4;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Employee_ID
            // 
            Employee_ID.DataPropertyName = "EmployeeId";
            Employee_ID.HeaderText = "Employee Id";
            Employee_ID.MinimumWidth = 6;
            Employee_ID.Name = "Employee_ID";
            Employee_ID.ReadOnly = true;
            // 
            // EmployeeName
            // 
            EmployeeName.DataPropertyName = "EmployeeName";
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
            dataGridView2.Location = new Point(0, 161);
            dataGridView2.Margin = new Padding(3, 15, 3, 3);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersVisible = false;
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(469, 228);
            dataGridView2.TabIndex = 5;
            // 
            // EmpId
            // 
            EmpId.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            EmpId.DataPropertyName = "EmployeeId";
            EmpId.HeaderText = "Employee Id";
            EmpId.MinimumWidth = 6;
            EmpId.Name = "EmpId";
            EmpId.ReadOnly = true;
            EmpId.Visible = false;
            // 
            // TaskId
            // 
            TaskId.DataPropertyName = "TaskId";
            TaskId.HeaderText = "Task Id";
            TaskId.MinimumWidth = 6;
            TaskId.Name = "TaskId";
            TaskId.ReadOnly = true;
            // 
            // TaskDiscription
            // 
            TaskDiscription.DataPropertyName = "TaskDiscrption";
            TaskDiscription.HeaderText = "Task Discription";
            TaskDiscription.MinimumWidth = 6;
            TaskDiscription.Name = "TaskDiscription";
            TaskDiscription.ReadOnly = true;
            // 
            // TaskStatus
            // 
            TaskStatus.DataPropertyName = "TaskStatus";
            TaskStatus.HeaderText = "Task Status";
            TaskStatus.MinimumWidth = 6;
            TaskStatus.Name = "TaskStatus";
            TaskStatus.ReadOnly = true;
            // 
            // AdminDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 242, 245);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(711, 395);
            ControlBox = false;
            Controls.Add(panel3);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
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
        private Button show_tasks;
        private DataGridViewTextBoxColumn Employee_ID;
        private DataGridViewTextBoxColumn EmployeeName;
        private DataGridViewTextBoxColumn EmpId;
        private DataGridViewTextBoxColumn TaskId;
        private DataGridViewTextBoxColumn TaskDiscription;
        private DataGridViewTextBoxColumn TaskStatus;
    }
}