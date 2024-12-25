using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess
{
    //generic costraint-- generic kısıt demek 
    //T:class dedigimizde referans tip olmalı, IEntity olabilir ya da IEntity implemente eden bir nesne olabilir
    //new(): newlenebilir olmalı
    public interface IEntityRepository<T> where T:class,IEntity,new()
    {
        List<T> GetAll(Expression<Func<T,bool>> filter=null); //Burası bizim filtreler yazabilmemizi sağlıyor.
        T Get(Expression<Func<T, bool>> filter); // tek bir data getirmek için
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);

    }
}
