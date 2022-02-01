using MongoDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
  public  class BookStoreDatabaseSettings
    {
        public string ConnectionString { get; set; } = null;

        public string DatabaseName { get; set; } = null;

         public string BooksCollectionName { get; set; } = null;

        public MongoClient DbClient { get; set; }
        public IMongoDatabase Db { get; set; }
        public BookStoreDatabaseSettings()
        {
            ConnectionString = "mongodb://127.0.0.1:27017";
            DatabaseName = "bookstore";

            DbClient = new MongoClient(ConnectionString);
            Db = DbClient.GetDatabase(DatabaseName);
        }

       
    }
}
