using System;

namespace ClassLibrary1
{
    internal class musicCompositionEntities
    {
        internal object GetDbSet<T>() where T : class
        {
            throw new NotImplementedException();
        }

        internal object GetCollection<T>() where T : class
        {
            throw new NotImplementedException();
        }

        internal object Entry<T>(T entity) where T : class
        {
            throw new NotImplementedException();
        }

        internal void SaveChanges()
        {
            throw new NotImplementedException();
        }
    }
}