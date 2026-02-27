namespace Assignment_1
{
    partial class SignUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUp));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            roleBox = new ComboBox();
            employeeId = new TextBox();
            employee_name = new TextBox();
            createAccount = new Button();
            employee_password = new TextBox();
            sign_up_label = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(roleBox);
            panel1.Controls.Add(employeeId);
            panel1.Controls.Add(employee_name);
            panel1.Controls.Add(createAccount);
            panel1.Controls.Add(employee_password);
            panel1.Controls.Add(sign_up_label);
            panel1.Location = new Point(6, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(315, 330);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(83, 10);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(158, 45);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // roleBox
            // 
            roleBox.DropDownStyle = ComboBoxStyle.DropDownList;
            roleBox.FormattingEnabled = true;
            roleBox.Items.AddRange(new object[] { "Admin", "Employee" });
            roleBox.Location = new Point(53, 240);
            roleBox.Name = "roleBox";
            roleBox.Size = new Size(196, 23);
            roleBox.TabIndex = 6;
            // 
            // employeeId
            // 
            employeeId.BackColor = SystemColors.Window;
            employeeId.Location = new Point(53, 109);
            employeeId.Name = "employeeId";
            employeeId.PlaceholderText = "Enter employee Id";
            employeeId.Size = new Size(196, 23);
            employeeId.TabIndex = 0;
            employeeId.TabStop = false;
            // 
            // employee_name
            // 
            employee_name.Location = new Point(53, 158);
            employee_name.Name = "employee_name";
            employee_name.PlaceholderText = "Enter employee name";
            employee_name.Size = new Size(196, 23);
            employee_name.TabIndex = 5;
            employee_name.TabStop = false;
            // 
            // createAccount
            // 
            createAccount.BackColor = Color.RoyalBlue;
            createAccount.FlatStyle = FlatStyle.Flat;
            createAccount.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            createAccount.ForeColor = Color.Transparent;
            createAccount.Location = new Point(83, 285);
            createAccount.Name = "createAccount";
            createAccount.Size = new Size(129, 36);
            createAccount.TabIndex = 4;
            createAccount.Text = "Create Account";
            createAccount.UseVisualStyleBackColor = false;
            createAccount.Click += createAccount_Click;
            // 
            // employee_password
            // 
            employee_password.Location = new Point(53, 199);
            employee_password.Name = "employee_password";
            employee_password.PlaceholderText = "Enter password";
            employee_password.Size = new Size(196, 23);
            employee_password.TabIndex = 2;
            employee_password.TabStop = false;
            // 
            // sign_up_label
            // 
            sign_up_label.AutoSize = true;
            sign_up_label.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            sign_up_label.ForeColor = Color.FromArgb(31, 41, 51);
            sign_up_label.Location = new Point(122, 68);
            sign_up_label.Name = "sign_up_label";
            sign_up_label.Size = new Size(70, 21);
            sign_up_label.TabIndex = 0;
            sign_up_label.Text = "Sign Up";
            // 
            // SignUp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 250);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(329, 333);
            Controls.Add(panel1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SignUp";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sign_Up";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label sign_up_label;
        private TextBox employee_password;
        private Button createAccount;
        private TextBox employee_name;
        private TextBox employeeId;
        private PictureBox pictureBox1;
        private ComboBox roleBox;
    }
}