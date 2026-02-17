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
            employeeId = new TextBox();
            employee_name = new TextBox();
            createAccount = new Button();
            employee_password = new TextBox();
            sign_up_label = new Label();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            roleBox = new ComboBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(roleBox);
            panel1.Controls.Add(employeeId);
            panel1.Controls.Add(employee_name);
            panel1.Controls.Add(createAccount);
            panel1.Controls.Add(employee_password);
            panel1.Controls.Add(sign_up_label);
            panel1.Location = new Point(251, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(315, 344);
            panel1.TabIndex = 0;
            // 
            // employeeId
            // 
            employeeId.BackColor = SystemColors.Window;
            employeeId.Location = new Point(53, 56);
            employeeId.Name = "employeeId";
            employeeId.PlaceholderText = "Enter employee Id";
            employeeId.Size = new Size(196, 23);
            employeeId.TabIndex = 1;
            // 
            // employee_name
            // 
            employee_name.Location = new Point(53, 101);
            employee_name.Name = "employee_name";
            employee_name.PlaceholderText = "Enter employee name";
            employee_name.Size = new Size(196, 23);
            employee_name.TabIndex = 5;
            // 
            // createAccount
            // 
            createAccount.BackColor = Color.RoyalBlue;
            createAccount.FlatStyle = FlatStyle.Flat;
            createAccount.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            createAccount.ForeColor = Color.Transparent;
            createAccount.Location = new Point(78, 241);
            createAccount.Name = "createAccount";
            createAccount.Size = new Size(129, 36);
            createAccount.TabIndex = 4;
            createAccount.Text = "Create Account";
            createAccount.UseVisualStyleBackColor = false;
            createAccount.Click += createAccount_Click;
            // 
            // employee_password
            // 
            employee_password.Location = new Point(53, 149);
            employee_password.Name = "employee_password";
            employee_password.PlaceholderText = "Enter password";
            employee_password.Size = new Size(196, 23);
            employee_password.TabIndex = 2;
            // 
            // sign_up_label
            // 
            sign_up_label.AutoSize = true;
            sign_up_label.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            sign_up_label.Location = new Point(118, 18);
            sign_up_label.Name = "sign_up_label";
            sign_up_label.Size = new Size(70, 21);
            sign_up_label.TabIndex = 0;
            sign_up_label.Text = "Sign Up";
      
            // 
            // panel2
            // 
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(3, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(245, 344);
            panel2.TabIndex = 6;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Dock = DockStyle.Bottom;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(245, 344);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // roleBox
            // 
            roleBox.FormattingEnabled = true;
            roleBox.Items.AddRange(new object[] { "Admin", "Employee" });
            roleBox.Location = new Point(53, 193);
            roleBox.Name = "roleBox";
            roleBox.Size = new Size(196, 23);
            roleBox.TabIndex = 6;
            // 
            // SignUp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(566, 344);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "SignUp";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sign_Up";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
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
        private Panel panel2;
        private PictureBox pictureBox1;
        private ComboBox roleBox;
    }
}