using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DBfiles
{
   public  class UserService
    {
        public static List<User> GetCollection()
        {
            var dbClient = new DBSetting();
            var usersCollection = dbClient.Db.GetCollection<User>("Users");
            List<User> documents = IMongoCollectionExtensions.Find<User>(usersCollection, u => true).ToList();
            return documents;
        }

        public static List<Contact> GetContact(string id)
        {
            var dbClient = new DBSetting();
            var contactCollection = dbClient.Db.GetCollection<Contact>("Contacts");
            List<Contact> documents = IMongoCollectionExtensions.Find(contactCollection, c => c.IdUser.Equals(id)).ToList();
            return documents;
        }

        public static User Insert(User b)
        {
            var dbClient = new DBSetting();
            var users = dbClient.Db.GetCollection<BsonDocument>("Users");
            b.IdUser = ObjectId.GenerateNewId().ToString();
            var doc = b.ToBsonDocument();
          
            users.InsertOne(doc);
            return b;
        }

        public static void Update(string id, User b)
        {
            var dbClient = new DBSetting();
            var users = dbClient.Db.GetCollection<BsonDocument>("Users");
            var filter = Builders<BsonDocument>.Filter.Eq("IdUser", id);
            var update = b.ToBsonDocument();
            users.ReplaceOne(filter, update);
        }

        public static void Delete(string id)
        {
            var dbClient = new DBSetting();

            var users = dbClient.Db.GetCollection<BsonDocument>("Users");

            var filter = Builders<BsonDocument>.Filter.Eq("IdUser", id);

            users.DeleteOne(filter);

        }

        public static Contact InsertForm(Contact c)
        {
            var dbform = new DBSetting();
            var form = dbform.Db.GetCollection<BsonDocument>("Contacts");
            c.userId = ObjectId.GenerateNewId().ToString();
            var doc = c.ToBsonDocument();

            form.InsertOne(doc);
            return c;
        }
    }
}
