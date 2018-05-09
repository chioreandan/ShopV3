using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GlobalShop
{
    public partial class UserInfo : Form
    {
        User user;
        public UserInfo()
        {
            InitializeComponent();
        }
        public UserInfo(User user)
        {
            this.user = user;
        }
        public System.Windows.Forms.Label returnEmail()
        {

            return emailtxt;
        }
        public System.Windows.Forms.Label returnTelfon()
        {
            return telefontxt;
        }
        public System.Windows.Forms.Label returnAdresa()
        {
            return adresatxt;
        }
        public System.Windows.Forms.Label returnNickname()
        {
            return nicknametxt;
        }
        public System.Windows.Forms.Label returnName()
        {
            return usersNameAppend;
        }

        private void UserInfo_Load(object sender, EventArgs e)
        {
            
        }
    }
}
