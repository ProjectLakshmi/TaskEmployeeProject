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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeDashboard));
            dataGridView1 = new DataGridView();
            TaskId = new DataGridViewTextBoxColumn();
            TaskDiscription = new DataGridViewTextBoxColumn();
            TaskStatus = new DataGridViewCheckBoxColumn();
            Add = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            delete_Task = new Button();
            edit_task = new Button();
            panel3 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Desktop;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { TaskId, TaskDiscription, TaskStatus });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.GridColor = SystemColors.ButtonShadow;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(697, 211);
            dataGridView1.TabIndex = 6;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // TaskId
            // 
            TaskId.DataPropertyName = "task_id";
            TaskId.HeaderText = "Task Id";
            TaskId.Name = "TaskId";
            TaskId.ReadOnly = true;
            // 
            // TaskDiscription
            // 
            TaskDiscription.DataPropertyName = "task_discrption";
            TaskDiscription.HeaderText = "Task Discription";
            TaskDiscription.Name = "TaskDiscription";
            TaskDiscription.ReadOnly = true;
            // 
            // TaskStatus
            // 
            TaskStatus.DataPropertyName = "task_status";
            TaskStatus.HeaderText = "Task Status";
            TaskStatus.Name = "TaskStatus";
            TaskStatus.ReadOnly = true;
            TaskStatus.Resizable = DataGridViewTriState.True;
            TaskStatus.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // Add
            // 
            Add.BackColor = Color.RoyalBlue;
            Add.FlatAppearance.BorderSize = 0;
            Add.FlatStyle = FlatStyle.Flat;
            Add.Font = new Font("Sitka Small", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Add.ForeColor = Color.White;
            Add.Location = new Point(3, 3);
            Add.Name = "Add";
            Add.Size = new Size(102, 44);
            Add.TabIndex = 7;
            Add.Text = "AddTask";
            Add.UseVisualStyleBackColor = false;
            Add.Click += Add_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(699, 353);
            panel1.TabIndex = 8;
            // 
            // panel2
            // 
            panel2.Controls.Add(delete_Task);
            panel2.Controls.Add(edit_task);
            panel2.Controls.Add(Add);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(697, 52);
            panel2.TabIndex = 10;
            // 
            // delete_Task
            // 
            delete_Task.BackColor = Color.RoyalBlue;
            delete_Task.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            delete_Task.ForeColor = SystemColors.Window;
            delete_Task.Location = new Point(245, 4);
            delete_Task.Name = "delete_Task";
            delete_Task.Size = new Size(110, 44);
            delete_Task.TabIndex = 9;
            delete_Task.Text = "Delete Task";
            delete_Task.UseVisualStyleBackColor = false;
            delete_Task.Click += delete_Task_Click;
            // 
            // edit_task
            // 
            edit_task.BackColor = Color.RoyalBlue;
            edit_task.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            edit_task.ForeColor = SystemColors.Window;
            edit_task.Location = new Point(125, 3);
            edit_task.Name = "edit_task";
            edit_task.Size = new Size(105, 44);
            edit_task.TabIndex = 8;
            edit_task.Text = "Edit Task";
            edit_task.UseVisualStyleBackColor = false;
            edit_task.Click += button1_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(dataGridView1);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 52);
            panel3.Name = "panel3";
            panel3.Size = new Size(697, 211);
            panel3.TabIndex = 11;
            // 
            // EmployeeDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(45, 45, 48);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(699, 353);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "EmployeeDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EmployeeDashboard";
            Load += EmployeeDashboard_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dataGridView1;
        private Button Add;
        private Panel panel1;
        private Button delete_Task;
        private Button edit_task;
        private DataGridViewTextBoxColumn TaskId;
        private DataGridViewTextBoxColumn TaskDiscription;
        private DataGridViewCheckBoxColumn TaskStatus;
        private Panel panel2;
        private Panel panel3;
    }
}