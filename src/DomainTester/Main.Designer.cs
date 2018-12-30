namespace DomainTester
{
    partial class Main
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
            this.btnAuth = new System.Windows.Forms.Button();
            this.txbServer = new System.Windows.Forms.TextBox();
            this.txbUser = new System.Windows.Forms.TextBox();
            this.txbPwd = new System.Windows.Forms.TextBox();
            this.lblDomainServer = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblPwd = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAuth
            // 
            this.btnAuth.Location = new System.Drawing.Point(96, 92);
            this.btnAuth.Name = "btnAuth";
            this.btnAuth.Size = new System.Drawing.Size(75, 23);
            this.btnAuth.TabIndex = 0;
            this.btnAuth.Text = "Auth User";
            this.btnAuth.UseVisualStyleBackColor = true;
            this.btnAuth.Click += new System.EventHandler(this.btnAuth_Click);
            // 
            // txbServer
            // 
            this.txbServer.Location = new System.Drawing.Point(96, 12);
            this.txbServer.Name = "txbServer";
            this.txbServer.Size = new System.Drawing.Size(247, 20);
            this.txbServer.TabIndex = 1;
            // 
            // txbUser
            // 
            this.txbUser.Location = new System.Drawing.Point(96, 39);
            this.txbUser.Name = "txbUser";
            this.txbUser.Size = new System.Drawing.Size(247, 20);
            this.txbUser.TabIndex = 2;
            // 
            // txbPwd
            // 
            this.txbPwd.Location = new System.Drawing.Point(96, 66);
            this.txbPwd.Name = "txbPwd";
            this.txbPwd.Size = new System.Drawing.Size(247, 20);
            this.txbPwd.TabIndex = 3;
            // 
            // lblDomainServer
            // 
            this.lblDomainServer.AutoSize = true;
            this.lblDomainServer.Location = new System.Drawing.Point(13, 12);
            this.lblDomainServer.Name = "lblDomainServer";
            this.lblDomainServer.Size = new System.Drawing.Size(77, 13);
            this.lblDomainServer.TabIndex = 4;
            this.lblDomainServer.Text = "Domain Server";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(13, 40);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(29, 13);
            this.lblUser.TabIndex = 4;
            this.lblUser.Text = "User";
            // 
            // lblPwd
            // 
            this.lblPwd.AutoSize = true;
            this.lblPwd.Location = new System.Drawing.Point(13, 68);
            this.lblPwd.Name = "lblPwd";
            this.lblPwd.Size = new System.Drawing.Size(53, 13);
            this.lblPwd.TabIndex = 4;
            this.lblPwd.Text = "Password";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 130);
            this.Controls.Add(this.lblPwd);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.lblDomainServer);
            this.Controls.Add(this.txbPwd);
            this.Controls.Add(this.txbUser);
            this.Controls.Add(this.txbServer);
            this.Controls.Add(this.btnAuth);
            this.MaximizeBox = false;
            this.Name = "Main";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DomainTester";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAuth;
        private System.Windows.Forms.TextBox txbServer;
        private System.Windows.Forms.TextBox txbUser;
        private System.Windows.Forms.TextBox txbPwd;
        private System.Windows.Forms.Label lblDomainServer;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblPwd;
    }
}

