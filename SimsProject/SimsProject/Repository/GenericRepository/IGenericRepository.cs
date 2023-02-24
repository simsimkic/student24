using SimsProject.Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimsProject.Repository.GenericRepository
{
    public interface IGenericRepository<T> where T:Entity
    {

        List<T> getAll();
        T save(T entity);
        T set(T entity);
        void delete(T entity);
    }
}
