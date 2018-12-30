using System;
using System.DirectoryServices;
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
            string domain = txbServer.Text;
            string user = txbUser.Text;
            string pass = txbPwd.Text;

            DirectoryEntry entry = new DirectoryEntry("LDAP://" + domain, user, pass);

            try
            {
                Object objnative = entry.NativeObject;
                MessageBox.Show("Auth Success!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Auth Error! " + ex.Message);
            }
        }
    }
}
