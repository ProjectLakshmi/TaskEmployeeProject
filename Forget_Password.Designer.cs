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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Forget_Password));
            new_pasword = new Label();
            confirm_password = new Label();
            newPasswordText = new TextBox();
            confirmPasswordtext = new TextBox();
            update_password = new Button();
            username = new Label();
            usernameText = new TextBox();
            verify_user = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // new_pasword
            // 
            new_pasword.AutoSize = true;
            new_pasword.ForeColor = Color.Transparent;
            new_pasword.Location = new Point(31, 111);
            new_pasword.Name = "new_pasword";
            new_pasword.Size = new Size(104, 20);
            new_pasword.TabIndex = 1;
            new_pasword.Text = "New Password";
            // 
            // confirm_password
            // 
            confirm_password.AutoSize = true;
            confirm_password.ForeColor = Color.Transparent;
            confirm_password.Location = new Point(31, 175);
            confirm_password.Name = "confirm_password";
            confirm_password.Size = new Size(127, 20);
            confirm_password.TabIndex = 2;
            confirm_password.Text = "Confirm Password";
            // 
            // newPasswordText
            // 
            newPasswordText.Location = new Point(31, 135);
            newPasswordText.Margin = new Padding(3, 4, 3, 4);
            newPasswordText.Name = "newPasswordText";
            newPasswordText.Size = new Size(390, 27);
            newPasswordText.TabIndex = 4;
            // 
            // confirmPasswordtext
            // 
            confirmPasswordtext.Location = new Point(31, 199);
            confirmPasswordtext.Margin = new Padding(3, 4, 3, 4);
            confirmPasswordtext.Name = "confirmPasswordtext";
            confirmPasswordtext.Size = new Size(390, 27);
            confirmPasswordtext.TabIndex = 5;
            // 
            // update_password
            // 
            update_password.Location = new Point(31, 245);
            update_password.Margin = new Padding(3, 4, 3, 4);
            update_password.Name = "update_password";
            update_password.Size = new Size(86, 31);
            update_password.TabIndex = 7;
            update_password.Text = "Update Password";
            update_password.UseVisualStyleBackColor = true;
            update_password.Click += update_password_Click;
            // 
            // username
            // 
            username.AutoSize = true;
            username.ForeColor = Color.Transparent;
            username.Location = new Point(31, 15);
            username.Name = "username";
            username.Size = new Size(75, 20);
            username.TabIndex = 8;
            username.Text = "Username";
            // 
            // usernameText
            // 
            usernameText.Location = new Point(31, 38);
            usernameText.Name = "usernameText";
            usernameText.Size = new Size(390, 27);
            usernameText.TabIndex = 9;
            // 
            // verify_user
            // 
            verify_user.Location = new Point(31, 71);
            verify_user.Name = "verify_user";
            verify_user.Size = new Size(75, 27);
            verify_user.TabIndex = 10;
            verify_user.Text = "Verify";
            verify_user.UseVisualStyleBackColor = true;
            verify_user.Click += verify_user_Click_1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(verify_user);
            panel1.Controls.Add(usernameText);
            panel1.Controls.Add(username);
            panel1.Controls.Add(update_password);
            panel1.Controls.Add(confirmPasswordtext);
            panel1.Controls.Add(newPasswordText);
            panel1.Controls.Add(confirm_password);
            panel1.Controls.Add(new_pasword);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(640, 359);
            panel1.TabIndex = 8;
            // 
            // panel2
            // 
            panel2.Location = new Point(117, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(472, 333);
            panel2.TabIndex = 9;
            // 
            // Forget_Password
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(640, 359);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
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
        private Panel panel2;
    }
}