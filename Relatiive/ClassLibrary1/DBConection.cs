using System;
using MongoDB.Driver;
using MongoDB.Bson;
using System.Collections.Generic;

namespace ClassLibrary1
{
    public class DBConection
    {
        public DBConection()
        {
        }

        public List<T> GetDbSet<T>() where T : class
        {
            using (musicCompositionEntities musicCompEntity = new musicCompositionEntities())
            {
                return musicCompEntity.GetDbSet<T>().ToList();
            }
        }

        public enum ExecuteActions
        {
            Insert,
            Update,
            Delete
        }

        public void Execute<T>(T entity, ExecuteActions exAction) where T : class
        {
            using (musicCompositionEntities musicCompEntity = new musicCompositionEntities())
            {
                var model = musicCompEntity.GetCollection<T>();
                switch (exAction)
                {
                    case ExecuteActions.Insert:
                        model.InsertOne(entity);
                        break;
                    case ExecuteActions.Update:
                        model.Attach(entity);
                        musicCompEntity.Entry(entity).State = System.Data.Entity.EntityState.UpdateOne;
                        break;
                    case ExecuteActions.Delete:
                        model.Attach(entity);
                        musicCompEntity.Entry(entity).State = System.Data.Entity.EntityState.DeleteOne;
                        break;
                    default:
                        break;
                }
                musicCompEntity.SaveChanges();

            }
        }
    }
}
