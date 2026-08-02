namespace Login_Screen
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.lbLoginTital = new System.Windows.Forms.Label();
            this.lbUsername = new System.Windows.Forms.Label();
            this.lbPassword = new System.Windows.Forms.Label();
            this.txUsername = new System.Windows.Forms.TextBox();
            this.txPassword = new System.Windows.Forms.TextBox();
            this.btLogin = new System.Windows.Forms.Button();
            this.ErrorProvidderForLogin = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvidderForLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // lbLoginTital
            // 
            this.lbLoginTital.AutoSize = true;
            this.lbLoginTital.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLoginTital.Location = new System.Drawing.Point(474, 121);
            this.lbLoginTital.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbLoginTital.Name = "lbLoginTital";
            this.lbLoginTital.Size = new System.Drawing.Size(60, 25);
            this.lbLoginTital.TabIndex = 0;
            this.lbLoginTital.Text = "Login";
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsername.Location = new System.Drawing.Point(214, 212);
            this.lbUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(102, 25);
            this.lbUsername.TabIndex = 1;
            this.lbUsername.Text = "Username";
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPassword.Location = new System.Drawing.Point(214, 288);
            this.lbPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(98, 25);
            this.lbPassword.TabIndex = 2;
            this.lbPassword.Text = "Password";
            // 
            // txUsername
            // 
            this.txUsername.Location = new System.Drawing.Point(417, 217);
            this.txUsername.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txUsername.Name = "txUsername";
            this.txUsername.Size = new System.Drawing.Size(189, 27);
            this.txUsername.TabIndex = 3;
            this.txUsername.Validating += new System.ComponentModel.CancelEventHandler(this.txUsername_Validating);
            // 
            // txPassword
            // 
            this.txPassword.Location = new System.Drawing.Point(417, 291);
            this.txPassword.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txPassword.Name = "txPassword";
            this.txPassword.Size = new System.Drawing.Size(189, 27);
            this.txPassword.TabIndex = 4;
            this.txPassword.UseSystemPasswordChar = true;
            this.txPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txPassword_Validating);
            // 
            // btLogin
            // 
            this.btLogin.Location = new System.Drawing.Point(417, 400);
            this.btLogin.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btLogin.Name = "btLogin";
            this.btLogin.Size = new System.Drawing.Size(190, 43);
            this.btLogin.TabIndex = 5;
            this.btLogin.Text = "Login\'";
            this.btLogin.UseVisualStyleBackColor = true;
            this.btLogin.Click += new System.EventHandler(this.btLogin_Click);
            // 
            // ErrorProvidderForLogin
            // 
            this.ErrorProvidderForLogin.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 563);
            this.Controls.Add(this.btLogin);
            this.Controls.Add(this.txPassword);
            this.Controls.Add(this.txUsername);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.lbUsername);
            this.Controls.Add(this.lbLoginTital);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvidderForLogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbLoginTital;
        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.TextBox txUsername;
        private System.Windows.Forms.TextBox txPassword;
        private System.Windows.Forms.Button btLogin;
        private System.Windows.Forms.ErrorProvider ErrorProvidderForLogin;
    }
}

