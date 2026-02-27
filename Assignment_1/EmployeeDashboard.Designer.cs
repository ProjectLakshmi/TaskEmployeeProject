namespace Assignment_1
{
    partial class EmployeeDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeDashboard));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            Add = new Button();
            logout = new Button();
            delete_Task = new Button();
            edit_task = new Button();
            panel4 = new Panel();
            employeeDashboard_label = new Label();
            pictureBox1 = new PictureBox();
            panel3 = new Panel();
            dataGridView1 = new DataGridView();
            TaskId = new DataGridViewTextBoxColumn();
            TaskDiscription = new DataGridViewTextBoxColumn();
            TaskStatus = new DataGridViewCheckBoxColumn();
            panel1 = new Panel();
            label1 = new Label();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // Add
            // 
            Add.BackColor = Color.FromArgb(59, 130, 246);
            Add.FlatAppearance.BorderSize = 0;
            Add.FlatStyle = FlatStyle.Flat;
            Add.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Add.ForeColor = Color.White;
            Add.Location = new Point(30, 58);
            Add.Name = "Add";
            Add.Size = new Size(88, 26);
            Add.TabIndex = 7;
            Add.Text = " +  Add";
            Add.UseVisualStyleBackColor = false;
            Add.Click += Add_Click;
            // 
            // logout
            // 
            logout.BackColor = Color.LightGray;
            logout.FlatAppearance.BorderSize = 0;
            logout.FlatStyle = FlatStyle.Flat;
            logout.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            logout.ForeColor = Color.Black;
            logout.Location = new Point(0, 311);
            logout.Name = "logout";
            logout.Size = new Size(190, 39);
            logout.TabIndex = 12;
            logout.Text = " ↪  Logout";
            logout.UseVisualStyleBackColor = false;
            logout.Click += logout_Click;
            // 
            // delete_Task
            // 
            delete_Task.BackColor = Color.White;
            delete_Task.FlatAppearance.BorderColor = Color.LightGray;
            delete_Task.FlatAppearance.BorderSize = 0;
            delete_Task.FlatStyle = FlatStyle.Flat;
            delete_Task.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            delete_Task.ForeColor = Color.Red;
            delete_Task.Location = new Point(250, 58);
            delete_Task.Name = "delete_Task";
            delete_Task.Size = new Size(105, 26);
            delete_Task.TabIndex = 9;
            delete_Task.Text = "  🗑  Delete";
            delete_Task.UseVisualStyleBackColor = false;
            delete_Task.Click += delete_Task_Click;
            // 
            // edit_task
            // 
            edit_task.BackColor = Color.White;
            edit_task.FlatAppearance.BorderColor = Color.LightGray;
            edit_task.FlatStyle = FlatStyle.Flat;
            edit_task.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            edit_task.ForeColor = Color.FromArgb(30, 41, 59);
            edit_task.Location = new Point(141, 58);
            edit_task.Name = "edit_task";
            edit_task.Size = new Size(88, 26);
            edit_task.TabIndex = 8;
            edit_task.Text = "  ✏  Edit";
            edit_task.UseVisualStyleBackColor = false;
            edit_task.Click += button1_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(15, 23, 42);
            panel4.Controls.Add(employeeDashboard_label);
            panel4.Controls.Add(pictureBox1);
            panel4.Controls.Add(logout);
            panel4.Dock = DockStyle.Left;
            panel4.Location = new Point(0, 0);
            panel4.Margin = new Padding(3, 2, 3, 2);
            panel4.Name = "panel4";
            panel4.Size = new Size(190, 353);
            panel4.TabIndex = 9;
            // 
            // employeeDashboard_label
            // 
            employeeDashboard_label.AutoSize = true;
            employeeDashboard_label.BackColor = Color.Transparent;
            employeeDashboard_label.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            employeeDashboard_label.ForeColor = Color.White;
            employeeDashboard_label.Location = new Point(12, 17);
            employeeDashboard_label.Name = "employeeDashboard_label";
            employeeDashboard_label.Size = new Size(157, 20);
            employeeDashboard_label.TabIndex = 14;
            employeeDashboard_label.Text = "Employee Dashboard";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(12, 58);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(172, 109);
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            panel3.Controls.Add(dataGridView1);
            panel3.Location = new Point(196, 139);
            panel3.Name = "panel3";
            panel3.Size = new Size(491, 211);
            panel3.TabIndex = 17;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(243, 244, 246);
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(59, 130, 246);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Desktop;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { TaskId, TaskDiscription, TaskStatus });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(219, 234, 254);
            dataGridViewCellStyle4.SelectionForeColor = Color.Black;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle4;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = SystemColors.ButtonShadow;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 35;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(491, 211);
            dataGridView1.TabIndex = 6;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
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
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            TaskDiscription.DefaultCellStyle = dataGridViewCellStyle3;
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
            TaskStatus.Resizable = DataGridViewTriState.True;
            TaskStatus.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(245, 247, 250);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(delete_Task);
            panel1.Controls.Add(Add);
            panel1.Controls.Add(edit_task);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(190, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(18, 8, 18, 8);
            panel1.Size = new Size(509, 114);
            panel1.TabIndex = 19;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(30, 41, 59);
            label1.Location = new Point(30, 9);
            label1.Name = "label1";
            label1.Size = new Size(175, 30);
            label1.TabIndex = 0;
            label1.Text = "Employee Tasks";
            // 
            // EmployeeDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(699, 353);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Controls.Add(panel4);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "EmployeeDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EmployeeDashboard";
            Load += EmployeeDashboard_Load;
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button Add;
        private Button delete_Task;
        private Button edit_task;
        private Button logout;
        private Panel panel4;
        private Panel panel3;
        private DataGridView dataGridView1;
        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private Label employeeDashboard_label;
        private DataGridViewTextBoxColumn TaskId;
        private DataGridViewTextBoxColumn TaskDiscription;
        private DataGridViewCheckBoxColumn TaskStatus;
    }
}