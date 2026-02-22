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
            panel1.Location = new Point(177, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(360, 445);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(95, 13);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(180, 60);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // roleBox
            // 
            roleBox.FormattingEnabled = true;
            roleBox.Items.AddRange(new object[] { "Admin", "Employee" });
            roleBox.Location = new Point(61, 325);
            roleBox.Margin = new Padding(3, 4, 3, 4);
            roleBox.Name = "roleBox";
            roleBox.Size = new Size(223, 28);
            roleBox.TabIndex = 6;
            // 
            // employeeId
            // 
            employeeId.BackColor = SystemColors.Window;
            employeeId.Location = new Point(68, 145);
            employeeId.Margin = new Padding(3, 4, 3, 4);
            employeeId.Name = "employeeId";
            employeeId.PlaceholderText = "Enter employee Id";
            employeeId.Size = new Size(223, 27);
            employeeId.TabIndex = 1;
            // 
            // employee_name
            // 
            employee_name.Location = new Point(61, 210);
            employee_name.Margin = new Padding(3, 4, 3, 4);
            employee_name.Name = "employee_name";
            employee_name.PlaceholderText = "Enter employee name";
            employee_name.Size = new Size(223, 27);
            employee_name.TabIndex = 5;
            // 
            // createAccount
            // 
            createAccount.BackColor = Color.RoyalBlue;
            createAccount.FlatStyle = FlatStyle.Flat;
            createAccount.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            createAccount.ForeColor = Color.Transparent;
            createAccount.Location = new Point(95, 381);
            createAccount.Margin = new Padding(3, 4, 3, 4);
            createAccount.Name = "createAccount";
            createAccount.Size = new Size(147, 48);
            createAccount.TabIndex = 4;
            createAccount.Text = "Create Account";
            createAccount.UseVisualStyleBackColor = false;
            createAccount.Click += createAccount_Click;
            // 
            // employee_password
            // 
            employee_password.Location = new Point(61, 265);
            employee_password.Margin = new Padding(3, 4, 3, 4);
            employee_password.Name = "employee_password";
            employee_password.PlaceholderText = "Enter password";
            employee_password.Size = new Size(223, 27);
            employee_password.TabIndex = 2;
            // 
            // sign_up_label
            // 
            sign_up_label.AutoSize = true;
            sign_up_label.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            sign_up_label.ForeColor = Color.FromArgb(31, 41, 51);
            sign_up_label.Location = new Point(140, 90);
            sign_up_label.Name = "sign_up_label";
            sign_up_label.Size = new Size(85, 28);
            sign_up_label.TabIndex = 0;
            sign_up_label.Text = "Sign Up";
            // 
            // SignUp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 250);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(689, 444);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
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