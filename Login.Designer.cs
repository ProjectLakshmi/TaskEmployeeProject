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
            label2 = new Label();
            label3 = new Label();
            Username = new TextBox();
            password_text = new TextBox();
            button1 = new Button();
            roleBox = new ComboBox();
            label4 = new Label();
            panel1 = new Panel();
            sign_up_label = new Label();
            forget_password = new Label();
            label1 = new Label();
            show_password = new CheckBox();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Sitka Small", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(44, 62, 80);
            label2.Location = new Point(19, 63);
            label2.Name = "label2";
            label2.Size = new Size(90, 23);
            label2.TabIndex = 1;
            label2.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Sitka Small", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(44, 62, 80);
            label3.Location = new Point(22, 94);
            label3.Name = "label3";
            label3.Size = new Size(87, 23);
            label3.TabIndex = 2;
            label3.Text = "Password";
            // 
            // Username
            // 
            Username.BackColor = Color.FromArgb(250, 250, 250);
            Username.BorderStyle = BorderStyle.FixedSingle;
            Username.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Username.ForeColor = Color.FromArgb(51, 51, 51);
            Username.Location = new Point(126, 63);
            Username.Name = "Username";
            Username.PlaceholderText = "Enter Username";
            Username.Size = new Size(205, 25);
            Username.TabIndex = 3;
            Username.Validating += Username_Validating;
            // 
            // password_text
            // 
            password_text.BorderStyle = BorderStyle.FixedSingle;
            password_text.Location = new Point(126, 94);
            password_text.Name = "password_text";
            password_text.PlaceholderText = "Enter Password";
            password_text.Size = new Size(205, 23);
            password_text.TabIndex = 4;
            password_text.UseSystemPasswordChar = true;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Highlight;
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Emoji", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(126, 190);
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
            roleBox.ForeColor = SystemColors.WindowText;
            roleBox.FormattingEnabled = true;
            roleBox.Items.AddRange(new object[] { "Admin", "Employee" });
            roleBox.Location = new Point(126, 148);
            roleBox.Name = "roleBox";
            roleBox.Size = new Size(199, 23);
            roleBox.TabIndex = 6;
            // 
            // label4
            // 
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Sitka Small", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(44, 62, 80);
            label4.Location = new Point(19, 148);
            label4.Name = "label4";
            label4.Size = new Size(87, 23);
            label4.TabIndex = 7;
            label4.Text = "Role";
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.BackColor = Color.White;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(sign_up_label);
            panel1.Controls.Add(forget_password);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(show_password);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(roleBox);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(password_text);
            panel1.Controls.Add(Username);
            panel1.ForeColor = Color.FromArgb(31, 41, 51);
            panel1.Location = new Point(265, 0);
            panel1.Margin = new Padding(3, 15, 3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(337, 333);
            panel1.TabIndex = 8;
            // 
            // sign_up_label
            // 
            sign_up_label.AutoSize = true;
            sign_up_label.Font = new Font("Segoe UI", 9F, FontStyle.Underline);
            sign_up_label.Location = new Point(126, 237);
            sign_up_label.Name = "sign_up_label";
            sign_up_label.Size = new Size(156, 15);
            sign_up_label.TabIndex = 11;
            sign_up_label.Text = "Don't have account?Sign Up";
            sign_up_label.Click += sign_up_label_Click;
            sign_up_label.MouseEnter += sign_up_label_MouseEnter;
            // 
            // forget_password
            // 
            forget_password.AutoSize = true;
            forget_password.Font = new Font("Segoe UI", 9F, FontStyle.Underline);
            forget_password.Location = new Point(126, 123);
            forget_password.Name = "forget_password";
            forget_password.Size = new Size(94, 15);
            forget_password.TabIndex = 10;
            forget_password.Text = "Forget Password";
            forget_password.Click += forget_password_Click;
            forget_password.MouseEnter += forget_password_MouseEnter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(126, 7);
            label1.Name = "label1";
            label1.Size = new Size(111, 20);
            label1.TabIndex = 8;
            label1.Text = "Welcome Back";
            // 
            // show_password
            // 
            show_password.AutoSize = true;
            show_password.Font = new Font("Segoe UI", 9F);
            show_password.Location = new Point(226, 123);
            show_password.Name = "show_password";
            show_password.Size = new Size(108, 19);
            show_password.TabIndex = 9;
            show_password.Text = "Show Password";
            show_password.UseVisualStyleBackColor = true;
            show_password.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(266, 333);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            
            // 
            // panel2
            // 
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(266, 333);
            panel2.TabIndex = 9;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(603, 333);
            Controls.Add(panel2);
            Controls.Add(panel1);
            ForeColor = Color.DimGray;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MinimizeBox = false;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label3;
        private TextBox Username;
        private TextBox password_text;
        private Button button1;
        private ComboBox roleBox;
        private Label label4;
        private Panel panel1;
        private Label label1;
        private CheckBox show_password;
        private Label forget_password;
        private Label sign_up_label;
        private PictureBox pictureBox1;
        private Panel panel2;
    }
}
