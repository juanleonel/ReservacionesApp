using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReservacionesApp.Interfaces
{
    public interface ICrud<T>
    {
        T Add(T entity);
        T Edit(T entity);
        T Remove(T entity);
        T GetById(string id);
        IQueryable<T> GetALL();
    }
}
