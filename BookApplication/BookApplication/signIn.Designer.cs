namespace BookApplication
{
    partial class signIn
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
            label1 = new Label();
            label2 = new Label();
            userNameTextBox = new TextBox();
            passwordTextBox = new TextBox();
            signInButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Bookman Old Style", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(266, 98);
            label1.Name = "label1";
            label1.Size = new Size(268, 38);
            label1.TabIndex = 6;
            label1.Text = "Welcome back!";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Bookman Old Style", 18F, FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(198, 142);
            label2.Name = "label2";
            label2.Size = new Size(405, 27);
            label2.TabIndex = 7;
            label2.Text = "Sign in to continue to your account";
            // 
            // userNameTextBox
            // 
            userNameTextBox.Location = new Point(278, 205);
            userNameTextBox.Name = "userNameTextBox";
            userNameTextBox.PlaceholderText = "Username";
            userNameTextBox.Size = new Size(244, 23);
            userNameTextBox.TabIndex = 8;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(278, 251);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.PasswordChar = '*';
            passwordTextBox.PlaceholderText = "Password";
            passwordTextBox.Size = new Size(244, 23);
            passwordTextBox.TabIndex = 9;
            // 
            // signInButton
            // 
            signInButton.Font = new Font("Bookman Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point);
            signInButton.Location = new Point(345, 308);
            signInButton.Name = "signInButton";
            signInButton.Size = new Size(111, 33);
            signInButton.TabIndex = 17;
            signInButton.Text = "Sign In";
            signInButton.UseVisualStyleBackColor = true;
            signInButton.Click += signInButton_Click;
            // 
            // signIn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(signInButton);
            Controls.Add(passwordTextBox);
            Controls.Add(userNameTextBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "signIn";
            Text = "Sign In";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox userNameTextBox;
        private TextBox passwordTextBox;
        private Button signInButton;
    }
}