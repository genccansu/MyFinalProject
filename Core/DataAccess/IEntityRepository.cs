
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess
{
    //Core evrensel katman,core katmanı diğer katmanları referans almaz. Alırsa bağımlı olmuş olur.
    public interface IEntityRepository <T> where T:class,IEntity,new() //referans tip
    {
        
        List<T> GetAll(Expression<Func<T,bool>> filter=null);
        //filtreleme için şart koyma.filtre null deme filtre vermeyebilirsin deme filtre vermemek hepsini getir demek
        T Get(Expression<Func<T,bool>> filter);

        void add(T entity);
        void Update(T entity);
        void Delete(T entity);

        
    }
}
