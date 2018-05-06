using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GlobalShop.Controllers.Seller;
using GlobalShop.Controllers.Administrator;
namespace GlobalShop.Controllers
{
    public class LoginController
    {
        public static bool Login(string email)
        {
            List<User> users = new List<User>();
            users = UserController.GetUsers().ToList();
            foreach(User user in users)
            {
                if (user.Email == email)
                {
                    return true;
                }
            }
            return false;

        }
        public static bool CheckPass(string email,string password)
        {
            User user = UserController.GetUser(email);
            if (user.Parola == password)
            {
                return true;
            }
            return false;

        }
       

        public static bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
        public static bool CheckVanzator(int id)
        {
            List<Vanzatori> vanzatori = new List<Vanzatori>();
            vanzatori=VanzatorController.GetUsers().ToList();
            foreach(Vanzatori v in vanzatori)
            {
                if (v.UserId == id)
                    return true;
            }
            return false;
        }
        public static bool CheckAdmin(int id)
        {
            List<Admin> admins = new List<Admin>();
            admins = AdminsController.GetAdmins().ToList();
            foreach (Admin a in admins)
            {
                if (a.UserId == id)
                    return true;
            }
            return false;
        }




    }
    
}
