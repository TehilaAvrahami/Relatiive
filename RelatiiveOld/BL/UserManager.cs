using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;


namespace BL
{
    public class UserManager
    {
        //שימוש במחלקה עם אנוטיישן של מונגו
        public static List<User> GetUsers()
        {
            List<User> list = UserService.GetCollection();
            return list;
        }

        //הרשמה
        public static User SignUp(User newUser)
        {
            return UserService.Insert(newUser);
        }

        //התחברות
        public static User SignIn(User oldUser)
        {
            string userName = oldUser.UserName;
            string password = oldUser.Password;
            List<User> usersCollection = UserService.GetCollection();
            User user = usersCollection.FirstOrDefault(u => u.UserName.Equals(userName) && u.Password.Equals(password));
            return user;

        }
    }
}
