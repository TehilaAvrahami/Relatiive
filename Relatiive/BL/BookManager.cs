using ClassLibrary1;
using ClassLibrary1.DALClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public static class BookManager
    {
        //בעיה עם שימוש במחלקות מונגו
        public static Object GetBooks()
        {
            DALBook dalBook = new DALBook();
            return DALBook.GetCollection();
        }
    }
}
