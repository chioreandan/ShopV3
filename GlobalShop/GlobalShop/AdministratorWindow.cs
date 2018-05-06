using GlobalShop.Controllers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace GlobalShop
{
    public partial class AdministratorWindow : Form
    {
        private static ShopEntities shop = new ShopEntities();
        public AdministratorWindow()
        {
            InitializeComponent();
        }

        private void viewUser_Click(object sender, EventArgs e)
        {
            List<User> users = new List<User>();
            users = UserController.GetUsers().ToList();
            viewUsersLIst.Items.AddRange(users.ToArray());
            viewUsersLIst.DisplayMember = "NumePrenume";
        }

        private void deleteUsers_Click(object sender, EventArgs e)
        {
            viewUsersLIst.Items.Remove(viewUsersLIst.SelectedItem);
            string numeUser = viewUsersLIst.GetItemText(viewUsersLIst.SelectedItem);
            DeleteUser(numeUser);
        }
        public void DeleteUser(string nume)
        {
            User delObj = shop.Users.Where(a => a.NumePrenume == nume).FirstOrDefault();
            shop.Users.Remove(delObj);
            shop.SaveChanges();
        }
    }
}
