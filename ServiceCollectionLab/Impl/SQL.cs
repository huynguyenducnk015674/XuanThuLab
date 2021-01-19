using System;
using System.Collections.Generic;

namespace ServiceCollectionLab.Impl
{
    class SQL : IDatabase
    {
        public void Delete(object o, int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(object o)
        {
            throw new NotImplementedException();
        }

        public List<object> Select()
        {
            Console.WriteLine("This is select of SQL");
            return new List<object>();
        }

        public void Update(object o, int id)
        {
            throw new NotImplementedException();
        }


    }
}
