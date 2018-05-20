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
            string numeUser = viewUsersLIst.GetItemText(viewUsersLIst.SelectedItem).ToString();
          
            Console.WriteLine(numeUser);
            //string numeUser = viewUsersLIst.SelectedItem.ToString();

            DeleteUser(numeUser);
        }
        public void DeleteUser(string nume)
        {
            User delObj = shop.Users.Where(a => a.NumePrenume == nume).FirstOrDefault();
            shop.Users.Remove(delObj);
            shop.SaveChanges();
        }

        private void info_user_Click(object sender, EventArgs e)
        {

            List<User> users = new List<User>();
            users = UserController.GetUsers().ToList();
            UserInfo info = new UserInfo();


            ShopEntities shop = new ShopEntities();
            string numeUser = viewUsersLIst.GetItemText(viewUsersLIst.SelectedItem).ToString();
            var getinformation = shop.Users.Where(a => a.NumePrenume == numeUser).FirstOrDefault();
            info.returnEmail().Text = getinformation.Email;
            info.returnAdresa().Text = getinformation.Adresa;
            info.returnNickname().Text = getinformation.Nickname;
            info.returnTelfon().Text = getinformation.Telefon;
            info.returnName().Text = "Informatii utilizator :" + getinformation.NumePrenume;
            info.Show();
        }
    }
}
