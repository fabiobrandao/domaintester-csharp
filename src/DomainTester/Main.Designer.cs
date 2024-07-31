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
            this.txbHost = new System.Windows.Forms.TextBox();
            this.txbUser = new System.Windows.Forms.TextBox();
            this.txbPwd = new System.Windows.Forms.TextBox();
            this.lblDomainServer = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblPwd = new System.Windows.Forms.Label();
            this.btnGetUsers = new System.Windows.Forms.Button();
            this.txbGroup = new System.Windows.Forms.TextBox();
            this.lblGroup = new System.Windows.Forms.Label();
            this.txbUsersByGroup = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAuth
            // 
            this.btnAuth.Location = new System.Drawing.Point(96, 116);
            this.btnAuth.Name = "btnAuth";
            this.btnAuth.Size = new System.Drawing.Size(75, 23);
            this.btnAuth.TabIndex = 0;
            this.btnAuth.Text = "Auth User";
            this.btnAuth.UseVisualStyleBackColor = true;
            this.btnAuth.Click += new System.EventHandler(this.btnAuth_Click);
            // 
            // txbServer
            // 
            this.txbHost.Location = new System.Drawing.Point(96, 12);
            this.txbHost.Name = "txbServer";
            this.txbHost.Size = new System.Drawing.Size(247, 20);
            this.txbHost.TabIndex = 1;
            // 
            // txbUser
            // 
            this.txbUser.Location = new System.Drawing.Point(96, 63);
            this.txbUser.Name = "txbUser";
            this.txbUser.Size = new System.Drawing.Size(247, 20);
            this.txbUser.TabIndex = 2;
            // 
            // txbPwd
            // 
            this.txbPwd.Location = new System.Drawing.Point(96, 90);
            this.txbPwd.Name = "txbPwd";
            this.txbPwd.Size = new System.Drawing.Size(247, 20);
            this.txbPwd.TabIndex = 3;
            // 
            // lblDomainServer
            // 
            this.lblDomainServer.AutoSize = true;
            this.lblDomainServer.Location = new System.Drawing.Point(13, 16);
            this.lblDomainServer.Name = "lblDomainServer";
            this.lblDomainServer.Size = new System.Drawing.Size(77, 13);
            this.lblDomainServer.TabIndex = 4;
            this.lblDomainServer.Text = "Domain Server";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(13, 67);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(29, 13);
            this.lblUser.TabIndex = 4;
            this.lblUser.Text = "User";
            // 
            // lblPwd
            // 
            this.lblPwd.AutoSize = true;
            this.lblPwd.Location = new System.Drawing.Point(13, 94);
            this.lblPwd.Name = "lblPwd";
            this.lblPwd.Size = new System.Drawing.Size(53, 13);
            this.lblPwd.TabIndex = 4;
            this.lblPwd.Text = "Password";
            // 
            // btnGetUsers
            // 
            this.btnGetUsers.Location = new System.Drawing.Point(96, 200);
            this.btnGetUsers.Name = "btnGetUsers";
            this.btnGetUsers.Size = new System.Drawing.Size(75, 23);
            this.btnGetUsers.TabIndex = 0;
            this.btnGetUsers.Text = "Get Users";
            this.btnGetUsers.UseVisualStyleBackColor = true;
            this.btnGetUsers.Click += new System.EventHandler(this.btnGetUsers_Click);
            // 
            // txbGroup
            // 
            this.txbGroup.Location = new System.Drawing.Point(96, 174);
            this.txbGroup.Name = "txbGroup";
            this.txbGroup.Size = new System.Drawing.Size(247, 20);
            this.txbGroup.TabIndex = 2;
            // 
            // lblGroup
            // 
            this.lblGroup.AutoSize = true;
            this.lblGroup.Location = new System.Drawing.Point(13, 178);
            this.lblGroup.Name = "lblGroup";
            this.lblGroup.Size = new System.Drawing.Size(36, 13);
            this.lblGroup.TabIndex = 4;
            this.lblGroup.Text = "Group";
            // 
            // txbUsersByGroup
            // 
            this.txbUsersByGroup.Location = new System.Drawing.Point(96, 230);
            this.txbUsersByGroup.Multiline = true;
            this.txbUsersByGroup.Name = "txbUsersByGroup";
            this.txbUsersByGroup.Size = new System.Drawing.Size(247, 113);
            this.txbUsersByGroup.TabIndex = 5;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 355);
            this.Controls.Add(this.txbUsersByGroup);
            this.Controls.Add(this.lblPwd);
            this.Controls.Add(this.lblGroup);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.lblDomainServer);
            this.Controls.Add(this.txbPwd);
            this.Controls.Add(this.txbGroup);
            this.Controls.Add(this.txbUser);
            this.Controls.Add(this.btnGetUsers);
            this.Controls.Add(this.txbHost);
            this.Controls.Add(this.btnAuth);
            this.MaximizeBox = false;
            this.Name = "Main";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DomainTester";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAuth;
        private System.Windows.Forms.TextBox txbHost;
        private System.Windows.Forms.TextBox txbUser;
        private System.Windows.Forms.TextBox txbPwd;
        private System.Windows.Forms.Label lblDomainServer;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblPwd;
        private System.Windows.Forms.Button btnGetUsers;
        private System.Windows.Forms.TextBox txbGroup;
        private System.Windows.Forms.Label lblGroup;
        private System.Windows.Forms.TextBox txbUsersByGroup;
    }
}

