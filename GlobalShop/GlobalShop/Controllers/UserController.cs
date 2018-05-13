using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GlobalShop.Controllers
{
    public class UserController 
    {
        private static ShopEntities shop = new ShopEntities();
        public static IEnumerable<User> GetUsers() => shop.Users.ToList();

        public static User GetUser(string email) => shop.Users.FirstOrDefault(u => u.Email == email);

        public static User GetUserById(int Id) => shop.Users.FirstOrDefault(u => u.UserId == Id);
        public static void Create(User user)
        {
            shop.Users.Add(user);
            shop.SaveChanges();
        }
        public static void UpdateUser(User user)
        {
            var entity = shop.Users.Find(user.UserId);
            if(entity== null)
            {
                return;
            }
            shop.Entry(entity).CurrentValues.SetValues(user);
        }
        public static void UserUpdateDate(string nume,string adresa,string telefon,int id)
        {
            User userToUpdate = UserController.GetUserById(id);

            userToUpdate.NumePrenume = nume;
            userToUpdate.Adresa = adresa;
            userToUpdate.Telefon = telefon;
            shop.SaveChanges();
            
        }
        public static void UserUpdateSecuritate(string email,string parola, int id)
        {
            User userToUpdate = UserController.GetUserById(id);
            userToUpdate.Email = email;
            userToUpdate.Parola = parola;
            shop.SaveChanges();
        }
        public static void DeleteUser(User user)
        {
            shop.Users.Remove(user);
            shop.SaveChanges();
        }
        

    }
}
