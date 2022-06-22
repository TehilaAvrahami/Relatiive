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
            string email = oldUser.Email;
            string pass = oldUser.Password;
            List<User> usersCollection = UserService.GetCollection();
            User user = usersCollection.FirstOrDefault(u => u.Email.Equals(email) && u.Password.Equals(pass));
            return user;
        }

        //הוספת טופס יצירת קשר
        public static Contact ContactForm(Contact newForm)
        {
            return UserService.InsertForm(newForm);
        }

        //החזרת טופס יצירת קשר
        public static List<Contact> RturnForm(string id)
        {
            return UserService.GetContact(id);
        }

        //עדכון
        //public static User UpdateUser(User user)
        //{
        //    string id = user.Id;
        //    return UserService.Update(id, user);
        //}
    }
}
