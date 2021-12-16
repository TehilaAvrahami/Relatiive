using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;

namespace trial
{
    class Program
    {
        static void Main(string[] args)
        {
            //1

            //var dbClient = new MongoClient("mongodb://127.0.0.1:27017");

            //IMongoDatabase db = dbClient.GetDatabase("bookstore");

            //var command = new BsonDocument { { "dbstats", 1 } };
            //var result = db.RunCommand<BsonDocument>(command);
            //Console.WriteLine(result.ToJson());


            //var books = db.GetCollection<BsonDocument>("Books");

            //var filter = Builders<BsonDocument>.Filter.Eq("Price", 43.15);

            //var doc = books.Find(filter).FirstOrDefault();
            //Console.WriteLine(doc.ToString());

            //2

            //var dbClient = new MongoClient("mongodb://127.0.0.1:27017");
            //IMongoDatabase db = dbClient.GetDatabase("bookstore");


            //var books = db.GetCollection<BsonDocument>("Books");
            //var filter = Builders<BsonDocument>.Filter.Empty;
            // var documents = books.Find(filter).ToList();

            //foreach (BsonDocument doc in documents)
            //{
            //    Console.WriteLine(doc.ToString());
            //}


            //3

            //var dbClient = new MongoClient("mongodb://127.0.0.1:27017");

            //IMongoDatabase db = dbClient.GetDatabase("bookstore");

            //var books = db.GetCollection<BsonDocument>("Books");

            //var builder = Builders<BsonDocument>.Filter;
            //var filter = builder.Gt("Price", 40) & builder.Lt("Price", 50);

            //var docs = books.Find(filter).ToList();

            //docs.ForEach(doc =>
            //{
            //    Console.WriteLine(doc);
            //});


            //4

            //var dbClient = new MongoClient("mongodb://127.0.0.1:27017");

            //IMongoDatabase db = dbClient.GetDatabase("bookstore");

            //var books = db.GetCollection<BsonDocument>("Books");

            //var doc = new BsonDocument
            //{
            //    {"Name", "aaaaa"},
            //    {"Price", 25.55},
            //    {"Category", "Computers"},
            //    { "Author", "BBBBB"}
            //};

            //books.InsertOne(doc);

            //var filter = Builders<BsonDocument>.Filter.Empty;
            //var documents = books.Find(filter).ToList();

            //foreach (BsonDocument doc1 in documents)
            //{
            //    Console.WriteLine(doc1.ToString());
            //}    


            //5

            //var dbClient = new MongoClient("mongodb://127.0.0.1:27017");

            //IMongoDatabase db = dbClient.GetDatabase("bookstore");

            //var books = db.GetCollection<BsonDocument>("Books");
            //var docs = books.Find(new BsonDocument()).Skip(1).Limit(4).ToList();

            //docs.ForEach(doc =>
            //{
            //    Console.WriteLine(doc);
            //});


            //6
            //var dbClient = new MongoClient("mongodb://127.0.0.1:27017");

            //IMongoDatabase db = dbClient.GetDatabase("bookstore");

            //var books = db.GetCollection<BsonDocument>("Books");
            //var docs = books.Find(new BsonDocument()).Project("{_id: 0}").ToList();

            //docs.ForEach(doc =>
            //{
            //    Console.WriteLine(doc);
            //});

            //7

            //var dbClient = new MongoClient("mongodb://127.0.0.1:27017");

            //IMongoDatabase db = dbClient.GetDatabase("bookstore");

            //var books = db.GetCollection<BsonDocument>("Books");

            //var filter = Builders<BsonDocument>.Filter.Eq("Name", "aaaaa");

            //books.DeleteOne(filter);

            //8
            var dbClient = new MongoClient("mongodb://127.0.0.1:27017");

            IMongoDatabase db = dbClient.GetDatabase("bookstore");

            var books = db.GetCollection<BsonDocument>("Books");

            var filter = Builders<BsonDocument>.Filter.Eq("Name", "aaaaa");
            var update = Builders<BsonDocument>.Update.Set("Price", 52000);

            books.UpdateOne(filter, update);


            Console.ReadLine();
        }
    }
}
