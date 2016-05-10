namespace IssueTracker
{
    partial class frmLoginScreen
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
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.lblLoginDescription = new System.Windows.Forms.Label();
            this.lblNameDescritpion = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(95, 62);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(121, 20);
            this.txtUserName.TabIndex = 0;
            // 
            // lblLoginDescription
            // 
            this.lblLoginDescription.AutoSize = true;
            this.lblLoginDescription.Location = new System.Drawing.Point(32, 25);
            this.lblLoginDescription.Name = "lblLoginDescription";
            this.lblLoginDescription.Size = new System.Drawing.Size(184, 13);
            this.lblLoginDescription.TabIndex = 2;
            this.lblLoginDescription.Text = "Please enter your username and login";
            // 
            // lblNameDescritpion
            // 
            this.lblNameDescritpion.AutoSize = true;
            this.lblNameDescritpion.Location = new System.Drawing.Point(29, 65);
            this.lblNameDescritpion.Name = "lblNameDescritpion";
            this.lblNameDescritpion.Size = new System.Drawing.Size(60, 13);
            this.lblNameDescritpion.TabIndex = 3;
            this.lblNameDescritpion.Text = "User Name";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(56, 100);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(151, 100);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmLoginScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 141);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lblNameDescritpion);
            this.Controls.Add(this.lblLoginDescription);
            this.Controls.Add(this.txtUserName);
            this.Name = "frmLoginScreen";
            this.Text = "LoginScreen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLoginDescription;
        private System.Windows.Forms.Label lblNameDescritpion;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtUserName;
    }
}