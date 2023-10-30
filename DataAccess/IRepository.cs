using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public interface IRepository<T>
    {
        event EventHandler<T> OnRepositoryChanged;
        public T Create(T entity);
        public ICollection<T> Read(int count = -1);
        public bool Save(T entity);
        public bool Delete(T entity);
        
        public TResult Foldl<TResult>(
            Func<T, TResult?, TResult?> accumulator, TResult? start);
    }
}
