﻿using MongoDB.Bson;
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
            List<User> documents = IMongoCollectionExtensions.Find<User>(usersCollection, u => u.FirstName.Contains("ch")).ToList();
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
    }
}