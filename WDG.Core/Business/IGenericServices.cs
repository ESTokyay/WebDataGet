using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using WDG.Core.Entities;

namespace WDG.Core.Business
{
    public interface IGenericServices<T> where T: class , IEntity, new()
    {
        T Get(Expression<Func<T, bool>> filter = null);
        List<T> GetList(Expression<Func<T, bool>> filter = null);

        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);
    }

}
