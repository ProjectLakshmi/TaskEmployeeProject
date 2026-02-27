namespace Assignment_1
{
    partial class Employee_Task_Add
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
            components = new System.ComponentModel.Container();
            label3 = new Label();
            label4 = new Label();
            textBox2 = new TextBox();
            button1 = new Button();
            EmployeeId = new Label();
            employee_Id = new TextBox();
            status_box = new ComboBox();
            panel1 = new Panel();
            panel2 = new Panel();
            add_label = new Label();
            toolTip1 = new ToolTip(components);
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(55, 65, 81);
            label3.Location = new Point(98, 127);
            label3.Name = "label3";
            label3.Size = new Size(120, 20);
            label3.TabIndex = 2;
            label3.Text = "Task Description";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(55, 65, 81);
            label4.Location = new Point(98, 203);
            label4.Name = "label4";
            label4.Size = new Size(83, 20);
            label4.TabIndex = 3;
            label4.Text = "Task Status";
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox2.BackColor = Color.FromArgb(249, 250, 251);
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(0, -2);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.ScrollBars = ScrollBars.Vertical;
            textBox2.Size = new Size(156, 23);
            textBox2.TabIndex = 5;
            textBox2.TextChanged += textBox2_TextChanged;
            textBox2.MouseHover += textBox2_MouseHover;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(59, 130, 246);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(113, 281);
            button1.Name = "button1";
            button1.Size = new Size(120, 40);
            button1.TabIndex = 8;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // EmployeeId
            // 
            EmployeeId.AutoSize = true;
            EmployeeId.BackColor = Color.Transparent;
            EmployeeId.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EmployeeId.ForeColor = Color.FromArgb(55, 65, 81);
            EmployeeId.Location = new Point(98, 54);
            EmployeeId.Name = "EmployeeId";
            EmployeeId.Size = new Size(95, 20);
            EmployeeId.TabIndex = 9;
            EmployeeId.Text = "Employee ID";
            // 
            // employee_Id
            // 
            employee_Id.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            employee_Id.BackColor = Color.FromArgb(249, 250, 251);
            employee_Id.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            employee_Id.Location = new Point(98, 88);
            employee_Id.Name = "employee_Id";
            employee_Id.ReadOnly = true;
            employee_Id.Size = new Size(158, 27);
            employee_Id.TabIndex = 10;
            // 
            // status_box
            // 
            status_box.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            status_box.BackColor = Color.FromArgb(249, 250, 251);
            status_box.DropDownStyle = ComboBoxStyle.DropDownList;
            status_box.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            status_box.FormattingEnabled = true;
            status_box.Items.AddRange(new object[] { "Completed", "Not Completed" });
            status_box.Location = new Point(98, 235);
            status_box.Name = "status_box";
            status_box.Size = new Size(158, 28);
            status_box.TabIndex = 11;
            status_box.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(add_label);
            panel1.Controls.Add(status_box);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(employee_Id);
            panel1.Controls.Add(EmployeeId);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(12, 3);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(30);
            panel1.Size = new Size(354, 349);
            panel1.TabIndex = 12;
            panel1.Paint += panel1_Paint;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(textBox2);
            panel2.Location = new Point(98, 159);
            panel2.Name = "panel2";
            panel2.Size = new Size(158, 21);
            panel2.TabIndex = 13;
            // 
            // add_label
            // 
            add_label.AutoSize = true;
            add_label.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            add_label.ForeColor = Color.FromArgb(33, 37, 41);
            add_label.Location = new Point(116, 12);
            add_label.Name = "add_label";
            add_label.Size = new Size(153, 30);
            add_label.TabIndex = 12;
            add_label.Text = "Add New Task";
            // 
            // Employee_Task_Add
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 250);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(381, 353);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Employee_Task_Add";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add";
            Load += Employee_Task_Add_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label label3;
        private Label label4;
        private TextBox textBox2;
        private Button button1;
        private Label EmployeeId;
        private TextBox employee_Id;
        private ComboBox status_box;
        private Panel panel1;
        private Label add_label;
        private Panel panel2;
        private ToolTip toolTip1;
    }
}