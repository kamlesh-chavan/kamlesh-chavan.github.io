using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SmartMakaan.DAL
{
    public class Repository
    {
        static List<User> users = new List<User>() {

        new User() {Email="abc@gmail.com",Roles="Admin,Editor",Password="password" },
        new User() {Email="xyz@gmail.com",Roles="Editor",Password="password" }
        };

        public static User GetUserDetails(User user)
        {
            return users.Where(u => u.Email.ToLower() == user.Email.ToLower() &&
            u.Password == user.Password).FirstOrDefault();
        }
    }
}