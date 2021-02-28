
namespace Univer1
{
    partial class LoginWindow
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.loginLbl = new System.Windows.Forms.Label();
            this.LoginTextBox = new System.Windows.Forms.TextBox();
            this.PassLbl = new System.Windows.Forms.Label();
            this.PassTextBox1 = new System.Windows.Forms.TextBox();
            this.loginBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.loginLbl);
            this.groupBox1.Controls.Add(this.LoginTextBox);
            this.groupBox1.Controls.Add(this.PassLbl);
            this.groupBox1.Controls.Add(this.PassTextBox1);
            this.groupBox1.Controls.Add(this.loginBtn);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(249, 142);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Авторизация";
            // 
            // loginLbl
            // 
            this.loginLbl.AutoSize = true;
            this.loginLbl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.loginLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginLbl.Location = new System.Drawing.Point(3, 19);
            this.loginLbl.Name = "loginLbl";
            this.loginLbl.Size = new System.Drawing.Size(48, 20);
            this.loginLbl.TabIndex = 9;
            this.loginLbl.Text = "Login";
            // 
            // LoginTextBox
            // 
            this.LoginTextBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LoginTextBox.Location = new System.Drawing.Point(3, 39);
            this.LoginTextBox.Name = "LoginTextBox";
            this.LoginTextBox.Size = new System.Drawing.Size(243, 20);
            this.LoginTextBox.TabIndex = 8;
            // 
            // PassLbl
            // 
            this.PassLbl.AutoSize = true;
            this.PassLbl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PassLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PassLbl.Location = new System.Drawing.Point(3, 59);
            this.PassLbl.Name = "PassLbl";
            this.PassLbl.Size = new System.Drawing.Size(78, 20);
            this.PassLbl.TabIndex = 7;
            this.PassLbl.Text = "Password";
            // 
            // PassTextBox1
            // 
            this.PassTextBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PassTextBox1.Location = new System.Drawing.Point(3, 79);
            this.PassTextBox1.Name = "PassTextBox1";
            this.PassTextBox1.PasswordChar = '*';
            this.PassTextBox1.Size = new System.Drawing.Size(243, 20);
            this.PassTextBox1.TabIndex = 6;
            // 
            // loginBtn
            // 
            this.loginBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.loginBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginBtn.Location = new System.Drawing.Point(3, 99);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(243, 40);
            this.loginBtn.TabIndex = 5;
            this.loginBtn.Text = "Sing in";
            this.loginBtn.UseVisualStyleBackColor = true;
            // 
            // LoginWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(249, 142);
            this.Controls.Add(this.groupBox1);
            this.Name = "LoginWindow";
            this.Text = "LoginWindow";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label loginLbl;
        private System.Windows.Forms.TextBox LoginTextBox;
        private System.Windows.Forms.Label PassLbl;
        private System.Windows.Forms.TextBox PassTextBox1;
        private System.Windows.Forms.Button loginBtn;
    }
}