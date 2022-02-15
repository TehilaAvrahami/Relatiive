using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DBfiles
{
    class DBSetting
    {
        public string ConnectionString { get; set; } = null;

        public string DatabaseName { get; set; } = null;

        public string CollectionName { get; set; } = null;

        public MongoClient DbClient { get; set; }
        public IMongoDatabase Db { get; set; }
        public DBSetting()
        {
            ConnectionString = "mongodb://127.0.0.1:27017";
            DatabaseName = "Relatiive";
            CollectionName = "Users";
            DbClient = new MongoClient(ConnectionString);
            Db = DbClient.GetDatabase(DatabaseName);
        }
    }
}
