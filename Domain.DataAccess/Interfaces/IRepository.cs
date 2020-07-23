using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DataAccess.Interfaces
{
    public interface IRepository<T> where T : class
    {
        T Get(int id);

        IList<T> GetAll();

        T Create(T entity);

        T Edit(T entity);

        T Delete(int id);
    }
}
