using System.Collections.Generic;

namespace ServiceCollectionLab
{
    interface IDatabase
    {
        void Insert(object o);
        void Delete(object o, int id);
        void Update(object o, int id);
        List<object> Select();
    }
}
