using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.DBfiles;

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
            string FirstName = oldUser.FirstName;
            string IdUser = oldUser.IdUser;
            List<User> usersCollection = UserService.GetCollection();
            User user = usersCollection.FirstOrDefault(u => u.FirstName.Equals(FirstName) && u.IdUser.Equals(IdUser));
            return user;
        }
    }
}
