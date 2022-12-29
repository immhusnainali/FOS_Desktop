namespace FOS
{
    partial class LoginScreen
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
            this.btn_login = new System.Windows.Forms.Button();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_signuppassword = new System.Windows.Forms.TextBox();
            this.txt_signupusername = new System.Windows.Forms.TextBox();
            this.btn_signup = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_login
            // 
            this.btn_login.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_login.Location = new System.Drawing.Point(256, 288);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(137, 48);
            this.btn_login.TabIndex = 0;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // txt_username
            // 
            this.txt_username.Location = new System.Drawing.Point(220, 167);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(185, 27);
            this.txt_username.TabIndex = 1;
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(218, 221);
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '*';
            this.txt_password.Size = new System.Drawing.Size(185, 27);
            this.txt_password.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(21, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(538, 60);
            this.label1.TabIndex = 3;
            this.label1.Text = "Welcome to Login Page";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(119, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(123, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Password";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(589, 469);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPage1.BackgroundImage = global::FOS.Properties.Resources.OIP;
            this.tabPage1.Controls.Add(this.txt_username);
            this.tabPage1.Controls.Add(this.txt_password);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.btn_login);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(581, 436);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Login";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPage2.BackgroundImage = global::FOS.Properties.Resources.OIP__3_;
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.txt_signuppassword);
            this.tabPage2.Controls.Add(this.txt_signupusername);
            this.tabPage2.Controls.Add(this.btn_signup);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(581, 436);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "SignUP";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Black", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(17, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(604, 60);
            this.label6.TabIndex = 5;
            this.label6.Text = "Welcome to Signup Screen";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(48, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 41);
            this.label5.TabIndex = 4;
            this.label5.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(43, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 41);
            this.label4.TabIndex = 3;
            this.label4.Text = "Username";
            // 
            // txt_signuppassword
            // 
            this.txt_signuppassword.Location = new System.Drawing.Point(221, 223);
            this.txt_signuppassword.Name = "txt_signuppassword";
            this.txt_signuppassword.PasswordChar = '*';
            this.txt_signuppassword.Size = new System.Drawing.Size(201, 27);
            this.txt_signuppassword.TabIndex = 2;
            // 
            // txt_signupusername
            // 
            this.txt_signupusername.Location = new System.Drawing.Point(221, 156);
            this.txt_signupusername.Name = "txt_signupusername";
            this.txt_signupusername.Size = new System.Drawing.Size(201, 27);
            this.txt_signupusername.TabIndex = 1;
            // 
            // btn_signup
            // 
            this.btn_signup.Font = new System.Drawing.Font("Segoe UI Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_signup.Location = new System.Drawing.Point(299, 275);
            this.btn_signup.Name = "btn_signup";
            this.btn_signup.Size = new System.Drawing.Size(146, 65);
            this.btn_signup.TabIndex = 0;
            this.btn_signup.Text = "Sign Up";
            this.btn_signup.UseVisualStyleBackColor = true;
            this.btn_signup.Click += new System.EventHandler(this.btn_signup_Click);
            // 
            // LoginScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 467);
            this.Controls.Add(this.tabControl1);
            this.Name = "LoginScreen";
            this.Text = "Login & Sigin up";
            this.Load += new System.EventHandler(this.LoginScreen_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btn_login;
        private TextBox txt_username;
        private TextBox txt_password;
        private Label label1;
        private Label label2;
        private Label label3;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label label6;
        private Label label5;
        private Label label4;
        private TextBox txt_signuppassword;
        private TextBox txt_signupusername;
        private Button btn_signup;
    }
}