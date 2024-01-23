using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Interface
{
    interface IBaseRepository<T, TEntity>where T:Ientity<TEntity>
    {
        T Get(TEntity id);
        void Create(T item);
        void Update(T item);
        void Delete(TEntity id);
        List<T> GetAll();


    }
}
