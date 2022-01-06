using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;

namespace ClassLibrary1
{
    class DalBooks
    {

        //public enum ExecuteActions
        //{
        //    Insert,
        //    Update,
        //    Delete
        //}

        //public static void conenct(string DBname, string COLLname)
        //{
        //    var dbClient = new MongoClient("mongodb://127.0.0.1:27017");
        //    IMongoDatabase db = dbClient.GetDatabase(DBname);
        //    var tbl = db.GetCollection<BsonDocument>(COLLname);
        //}

        //public static void insret(string DBname, string COLLname, BsonDocument document)
        //{
        //   var list =  conenct(DBname, COLLname);
        //    var doc = new BsonDocument { document };
        //    COLLname.InsertOne(doc);
        //}

        //public static void delete(string DBname, string COLLname, BsonDocument doc, BsonDocument upDoc)
        //{
        //    conenct(DBname, COLLname);
        //    var filter = Builders<BsonDocument>.Filter.Eq(doc);
        //    var update = Builders<BsonDocument>.Update.Set(upDoc);
        //    COLLname.UpdateOne(filter, update);
        //}

        //public static void delete(string DBname, string COLLname, BsonDocument doc)
        //{
        //    conenct(DBname, COLLname);
        //    var filter = Builders<BsonDocument>.Filter.Eq(doc);
        //    COLLname.DeleteOne(filter);
        //}

    }
}
