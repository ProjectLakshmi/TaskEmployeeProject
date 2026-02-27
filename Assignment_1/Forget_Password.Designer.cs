namespace Assignment_1
{
    partial class Forget_Password
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
            new_pasword = new Label();
            confirm_password = new Label();
            newPasswordText = new TextBox();
            confirmPasswordtext = new TextBox();
            update_password = new Button();
            username = new Label();
            usernameText = new TextBox();
            verify_user = new Button();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // new_pasword
            // 
            new_pasword.AutoSize = true;
            new_pasword.BackColor = Color.Transparent;
            new_pasword.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            new_pasword.ForeColor = Color.FromArgb(108, 117, 125);
            new_pasword.Location = new Point(31, 113);
            new_pasword.Name = "new_pasword";
            new_pasword.Size = new Size(112, 20);
            new_pasword.TabIndex = 1;
            new_pasword.Text = "New Password";
            // 
            // confirm_password
            // 
            confirm_password.AutoSize = true;
            confirm_password.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            confirm_password.ForeColor = Color.FromArgb(108, 117, 125);
            confirm_password.Location = new Point(31, 218);
            confirm_password.Name = "confirm_password";
            confirm_password.Size = new Size(137, 20);
            confirm_password.TabIndex = 2;
            confirm_password.Text = "Confirm Password";
            // 
            // newPasswordText
            // 
            newPasswordText.BorderStyle = BorderStyle.FixedSingle;
            newPasswordText.Location = new Point(31, 165);
            newPasswordText.Margin = new Padding(3, 4, 3, 4);
            newPasswordText.Name = "newPasswordText";
            newPasswordText.Size = new Size(350, 27);
            newPasswordText.TabIndex = 4;
            newPasswordText.UseSystemPasswordChar = true;
            // 
            // confirmPasswordtext
            // 
            confirmPasswordtext.BorderStyle = BorderStyle.FixedSingle;
            confirmPasswordtext.Location = new Point(31, 259);
            confirmPasswordtext.Margin = new Padding(3, 4, 3, 4);
            confirmPasswordtext.Name = "confirmPasswordtext";
            confirmPasswordtext.Size = new Size(350, 27);
            confirmPasswordtext.TabIndex = 5;
            confirmPasswordtext.UseSystemPasswordChar = true;
            // 
            // update_password
            // 
            update_password.BackColor = Color.FromArgb(0, 123, 255);
            update_password.FlatStyle = FlatStyle.Flat;
            update_password.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            update_password.ForeColor = Color.White;
            update_password.Location = new Point(31, 326);
            update_password.Margin = new Padding(3, 4, 3, 4);
            update_password.Name = "update_password";
            update_password.Size = new Size(150, 40);
            update_password.TabIndex = 7;
            update_password.Text = "Update Password";
            update_password.UseVisualStyleBackColor = false;
            update_password.Click += update_password_Click;
            // 
            // username
            // 
            username.AutoSize = true;
            username.BackColor = Color.Transparent;
            username.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            username.ForeColor = Color.FromArgb(108, 117, 125);
            username.Location = new Point(31, 15);
            username.Name = "username";
            username.Size = new Size(80, 20);
            username.TabIndex = 8;
            username.Text = "Username";
            // 
            // usernameText
            // 
            usernameText.BorderStyle = BorderStyle.FixedSingle;
            usernameText.Location = new Point(31, 43);
            usernameText.Name = "usernameText";
            usernameText.Size = new Size(350, 27);
            usernameText.TabIndex = 9;
            // 
            // verify_user
            // 
            verify_user.FlatAppearance.BorderColor = Color.FromArgb(0, 123, 255);
            verify_user.FlatStyle = FlatStyle.Flat;
            verify_user.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            verify_user.ForeColor = Color.FromArgb(0, 123, 255);
            verify_user.Location = new Point(401, 37);
            verify_user.Name = "verify_user";
            verify_user.Size = new Size(150, 40);
            verify_user.TabIndex = 10;
            verify_user.Text = "Verify";
            verify_user.UseVisualStyleBackColor = true;
            verify_user.Click += verify_user_Click_1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(verify_user);
            panel1.Controls.Add(username);
            panel1.Controls.Add(usernameText);
            panel1.Controls.Add(update_password);
            panel1.Controls.Add(confirmPasswordtext);
            panel1.Controls.Add(newPasswordText);
            panel1.Controls.Add(confirm_password);
            panel1.Controls.Add(new_pasword);
            panel1.Location = new Point(8, 13);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(573, 399);
            panel1.TabIndex = 8;
            // 
            // Forget_Password
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 242, 245);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(593, 421);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Forget_Password";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Forget_Password";
            Load += Forget_Password_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label new_pasword;
        private Label confirm_password;
        private TextBox newPasswordText;
        private TextBox confirmPasswordtext;
        private Button update_password;
        private Label username;
        private TextBox usernameText;
        private Button verify_user;
        private Panel panel1;
    }
}