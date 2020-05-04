using BaseTestLib.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseTestLib.Classes
{
    public abstract class  Wrapper<T> : IWrapper<T> where T:class
    {
        TestModel context = null;
       public DbSet<T> Set { get; set; }

        public Wrapper(TestModel testContext)
        {
            context = testContext;
            Set = context.Set<T>();
        }
        public void AddItem(T item)
        {
            throw new NotImplementedException();
        }

        public void Delete(T item)
        {
            throw new NotImplementedException();
        }

      

        public IEnumerable<T> GetItems()
        {
            throw new NotImplementedException();
        }

        public void UpdateItem(T item)
        {
            throw new NotImplementedException();
        }

        T IWrapper<T>.Find(T entry)
        {
            throw new NotImplementedException();
        }
    }
}
