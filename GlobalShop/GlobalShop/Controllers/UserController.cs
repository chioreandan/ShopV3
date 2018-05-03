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

        public static User GetUser(string email)
        {
            return shop.Users.FirstOrDefault(u => u.Email == email);
        }
        public static void Create(User user)
        {
            shop.Users.Add(user);
            shop.SaveChanges();

        }

        
    }
}
