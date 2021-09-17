
namespace Librart_Management_System
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
            this.Login_UserName_Label = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.Login_Password_Label = new System.Windows.Forms.Label();
            this.Log_UserName_TextBox = new System.Windows.Forms.TextBox();
            this.Log_Password_TextBox = new System.Windows.Forms.TextBox();
            this.Log_button = new System.Windows.Forms.Button();
            this.Exit_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Login_UserName_Label
            // 
            this.Login_UserName_Label.AutoSize = true;
            this.Login_UserName_Label.BackColor = System.Drawing.SystemColors.Control;
            this.Login_UserName_Label.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Login_UserName_Label.Location = new System.Drawing.Point(96, 59);
            this.Login_UserName_Label.Name = "Login_UserName_Label";
            this.Login_UserName_Label.Size = new System.Drawing.Size(54, 17);
            this.Login_UserName_Label.TabIndex = 0;
            this.Login_UserName_Label.Text = "UserID: ";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.DarkRed;
            this.linkLabel1.Location = new System.Drawing.Point(409, 220);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(96, 15);
            this.linkLabel1.TabIndex = 1;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "ForgetPassword?";
            // 
            // Login_Password_Label
            // 
            this.Login_Password_Label.AutoSize = true;
            this.Login_Password_Label.BackColor = System.Drawing.SystemColors.Control;
            this.Login_Password_Label.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Login_Password_Label.Location = new System.Drawing.Point(96, 123);
            this.Login_Password_Label.Name = "Login_Password_Label";
            this.Login_Password_Label.Size = new System.Drawing.Size(73, 17);
            this.Login_Password_Label.TabIndex = 2;
            this.Login_Password_Label.Text = "Password:";
            // 
            // Log_UserName_TextBox
            // 
            this.Log_UserName_TextBox.BackColor = System.Drawing.Color.Peru;
            this.Log_UserName_TextBox.Location = new System.Drawing.Point(183, 57);
            this.Log_UserName_TextBox.Multiline = true;
            this.Log_UserName_TextBox.Name = "Log_UserName_TextBox";
            this.Log_UserName_TextBox.Size = new System.Drawing.Size(214, 30);
            this.Log_UserName_TextBox.TabIndex = 3;
            // 
            // Log_Password_TextBox
            // 
            this.Log_Password_TextBox.BackColor = System.Drawing.Color.Peru;
            this.Log_Password_TextBox.Location = new System.Drawing.Point(183, 123);
            this.Log_Password_TextBox.Multiline = true;
            this.Log_Password_TextBox.Name = "Log_Password_TextBox";
            this.Log_Password_TextBox.PasswordChar = '*';
            this.Log_Password_TextBox.Size = new System.Drawing.Size(214, 25);
            this.Log_Password_TextBox.TabIndex = 4;
            // 
            // Log_button
            // 
            this.Log_button.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Log_button.Location = new System.Drawing.Point(306, 184);
            this.Log_button.Name = "Log_button";
            this.Log_button.Size = new System.Drawing.Size(79, 35);
            this.Log_button.TabIndex = 5;
            this.Log_button.Text = "Login";
            this.Log_button.UseVisualStyleBackColor = true;
            this.Log_button.Click += new System.EventHandler(this.Log_button_Click);
            // 
            // Exit_button
            // 
            this.Exit_button.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Exit_button.Location = new System.Drawing.Point(121, 184);
            this.Exit_button.Name = "Exit_button";
            this.Exit_button.Size = new System.Drawing.Size(79, 35);
            this.Exit_button.TabIndex = 6;
            this.Exit_button.Text = "Exit";
            this.Exit_button.UseVisualStyleBackColor = true;
            this.Exit_button.Click += new System.EventHandler(this.Exit_button_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(545, 269);
            this.Controls.Add(this.Exit_button);
            this.Controls.Add(this.Log_button);
            this.Controls.Add(this.Log_Password_TextBox);
            this.Controls.Add(this.Log_UserName_TextBox);
            this.Controls.Add(this.Login_Password_Label);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.Login_UserName_Label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Login_UserName_Label;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label Login_Password_Label;
        private System.Windows.Forms.TextBox Log_UserName_TextBox;
        private System.Windows.Forms.TextBox Log_Password_TextBox;
        private System.Windows.Forms.Button Log_button;
        private System.Windows.Forms.Button Exit_button;
    }
}

