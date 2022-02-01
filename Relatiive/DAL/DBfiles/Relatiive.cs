using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB;
using MongoDB.Driver;

namespace ClassLibrary1.DBfiles
{
        class Relatiive
    {
        public string ConnectionString { get; set; } = null;

        public string DatabaseName { get; set; } = null;

        public string CollectionName { get; set; } = null;

        public MongoClient DbClient { get; set; }
        public IMongoDatabase Db { get; set; }
        public Relatiive()
        {
            ConnectionString = "mongodb://127.0.0.1:27017";
            DatabaseName = "Relatiive";
            CollectionName = "Users";
            DbClient = new MongoClient(ConnectionString);
            Db = DbClient.GetDatabase(DatabaseName);
        }
    }
}
