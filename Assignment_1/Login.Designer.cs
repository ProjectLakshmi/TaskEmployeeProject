namespace Assignment_1
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            Username = new TextBox();
            password_text = new TextBox();
            button1 = new Button();
            roleBox = new ComboBox();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            sign_up_label = new Label();
            forget_password = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Username
            // 
            Username.BackColor = Color.FromArgb(250, 250, 250);
            Username.BorderStyle = BorderStyle.FixedSingle;
            Username.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Username.ForeColor = Color.FromArgb(51, 51, 51);
            Username.Location = new Point(88, 80);
            Username.Name = "Username";
            Username.PlaceholderText = "Enter Username";
            Username.Size = new Size(205, 26);
            Username.TabIndex = 0;
            Username.TabStop = false;
            Username.Validating += Username_Validating;
            // 
            // password_text
            // 
            password_text.BorderStyle = BorderStyle.FixedSingle;
            password_text.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            password_text.Location = new Point(88, 123);
            password_text.Name = "password_text";
            password_text.PlaceholderText = "Enter Password";
            password_text.Size = new Size(205, 26);
            password_text.TabIndex = 4;
            password_text.TabStop = false;
            password_text.UseSystemPasswordChar = true;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Highlight;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(113, 249);
            button1.Name = "button1";
            button1.Size = new Size(123, 33);
            button1.TabIndex = 5;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = false;
            button1.Click += LginButton1_Click;
            // 
            // roleBox
            // 
            roleBox.BackColor = Color.White;
            roleBox.DropDownStyle = ComboBoxStyle.DropDownList;
            roleBox.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            roleBox.ForeColor = SystemColors.WindowText;
            roleBox.FormattingEnabled = true;
            roleBox.Items.AddRange(new object[] { "Admin", "Employee" });
            roleBox.Location = new Point(88, 191);
            roleBox.Name = "roleBox";
            roleBox.Size = new Size(199, 27);
            roleBox.TabIndex = 6;
            roleBox.TabStop = false;
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.BackColor = Color.White;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(sign_up_label);
            panel1.Controls.Add(forget_password);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(roleBox);
            panel1.Controls.Add(password_text);
            panel1.Controls.Add(Username);
            panel1.ForeColor = Color.FromArgb(31, 41, 51);
            panel1.Location = new Point(12, 1);
            panel1.Margin = new Padding(3, 15, 3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(346, 329);
            panel1.TabIndex = 8;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(249, 155);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(44, 15);
            pictureBox2.TabIndex = 13;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top;
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(101, 10);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(158, 45);
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // sign_up_label
            // 
            sign_up_label.AutoSize = true;
            sign_up_label.Font = new Font("Segoe UI", 9F, FontStyle.Underline);
            sign_up_label.Location = new Point(101, 298);
            sign_up_label.Name = "sign_up_label";
            sign_up_label.Size = new Size(156, 15);
            sign_up_label.TabIndex = 11;
            sign_up_label.Text = "Don't have account?Sign Up";
            sign_up_label.Click += sign_up_label_Click;
            sign_up_label.MouseEnter += sign_up_label_MouseEnter;
            sign_up_label.MouseLeave += sign_up_label_MouseLeave;
            // 
            // forget_password
            // 
            forget_password.AutoSize = true;
            forget_password.Font = new Font("Segoe UI", 9F, FontStyle.Underline);
            forget_password.Location = new Point(88, 152);
            forget_password.Name = "forget_password";
            forget_password.Size = new Size(94, 15);
            forget_password.TabIndex = 10;
            forget_password.Text = "Forget Password";
            forget_password.Click += forget_password_Click;
            forget_password.MouseEnter += forget_password_MouseEnter;
            forget_password.MouseLeave += forget_password_MouseLeave;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 250);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(365, 333);
            Controls.Add(panel1);
            ForeColor = Color.DimGray;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MinimizeBox = false;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox Username;
        private TextBox password_text;
        private Button button1;
        private ComboBox roleBox;
        private Panel panel1;
        private Label forget_password;
        private Label sign_up_label;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}
