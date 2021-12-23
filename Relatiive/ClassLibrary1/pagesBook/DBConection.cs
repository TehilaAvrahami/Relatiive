using System;
using MongoDB.Driver;
using MongoDB.Bson;
using System.Collections.Generic;

namespace ClassLibrary1
{
    public class DBConection
    {
        BookStoreDatabaseSettings BookStoreDatabaseSettings = new BookStoreDatabaseSettings();
        public DBConection()
        {
           
        }

        public IMongoCollection<T> GetDbSet<T>() where T : class
        {
            return BookStoreDatabaseSettings.Db.GetCollection<T>(typeof(T).Name);          
        }

        public enum ExecuteActions
        {
            Insert,
            Update,
            Delete
        }

        public void Execute<T>(T entity, ExecuteActions exAction) where T : class
        {
           var coll= BookStoreDatabaseSettings.Db.GetCollection<T>(typeof(T).Name);//שם הטבלה

            
                switch (exAction)
                {
                    case ExecuteActions.Insert:
                        coll.InsertOne(entity);
                        break;
                    case ExecuteActions.Update:
                        var filter = Builders<BsonDocument>.Filter.Eq(Id, );
                        coll.UpdateOne(entity);
                        
                        break;
                    case ExecuteActions.Delete:
                        coll.DeleteOne(entity);
                        break;
                    default:
                        break;
                }
               

            
        }

        private string Id(BsonDocument arg)
        {
            throw new NotImplementedException();
        }
    }
}
