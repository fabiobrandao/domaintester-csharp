using System;
using System.Collections.Generic;
using System.DirectoryServices;
using System.DirectoryServices.AccountManagement;
using System.Windows.Forms;

namespace DomainTester
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            txbPwd.PasswordChar = '*';
        }

        private void btnAuth_Click(object sender, EventArgs e)
        {
            string host = txbHost.Text;
            string user = txbUser.Text;
            string pass = txbPwd.Text;

            DirectoryEntry entry = new DirectoryEntry("LDAP://" + host, user, pass);

            try
            {
                object objnative = entry.NativeObject;
                MessageBox.Show("Auth Success", "Domain Tester", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Auth Error\n" + ex.Message, "Domain Tester", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGetUsers_Click(object sender, EventArgs e)
        {
            txbUsersByGroup.Text = string.Empty;

            try
            {
                string domain = txbHost.Text;
                string user = txbUser.Text;
                string pass = txbPwd.Text;
                string groupName = txbGroup.Text;

                List<string> users = new List<string>();

                using (PrincipalContext ctx = new PrincipalContext(ContextType.Domain, domain, user, pass))
                {
                    GroupPrincipal group = GroupPrincipal.FindByIdentity(ctx, groupName);

                    if (group != null)
                    {
                        foreach (Principal p in group.GetMembers())
                        {
                            string distinguishedName = p.DistinguishedName;
                            string name = p.Name;
                            string email = "";

                            using (DirectoryEntry de = (DirectoryEntry)p.GetUnderlyingObject())
                            {
                                email = de.Properties["mail"].Value as string;
                            }

                            users.Add(string.Format("{0}, {1}, {2}", name, email, distinguishedName));
                        }
                    }
                    else
                    {
                        MessageBox.Show("Group not found", "Domain Tester", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }

                foreach (var u in users)
                {
                    txbUsersByGroup.Text += u + "\n";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Get Users Error\n" + ex.Message, "Domain Tester", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}