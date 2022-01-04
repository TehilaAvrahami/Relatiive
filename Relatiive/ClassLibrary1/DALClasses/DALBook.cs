using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.DALClasses
{
    public class DALBook
    {

        public static Object GetCollection()
        {
            var dbClient = new BookStoreDatabaseSettings();
            var books = dbClient.Db.GetCollection<BsonDocument>("Books");
            return books;
        }
        public static void Insert(Book b)
        {
            var dbClient = new BookStoreDatabaseSettings();
            var books = dbClient.Db.GetCollection<BsonDocument>("Books");

            var doc = b.ToBsonDocument();
            books.InsertOne(doc);
        }
        public static void Update(string id, Book b)
        {
            var dbClient = new BookStoreDatabaseSettings();
            var books = dbClient.Db.GetCollection<BsonDocument>("Books");
            var filter = Builders<BsonDocument>.Filter.Eq("Id", id);
            var update = b.ToBsonDocument();
            books.ReplaceOne(filter, update);
        }
        public static void Delete(string id)
        {
            var dbClient = new BookStoreDatabaseSettings();

            var books = dbClient.Db.GetCollection<BsonDocument>("Books");

            var filter = Builders<BsonDocument>.Filter.Eq("Id", id);

            books.DeleteOne(filter);

        }
    }
}
