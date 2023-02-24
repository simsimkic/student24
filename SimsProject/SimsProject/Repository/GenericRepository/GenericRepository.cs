using SimsProject.helpers;
using SimsProject.Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimsProject.Repository.GenericRepository
{
    public abstract class GenericRepository<T> where T:Entity
    {
        private String filePath;
        XmlReaderWriter rw = new XmlReaderWriter();

        public GenericRepository(String filePath)
        {
            this.filePath = filePath;
        }

        public List<T> getAll()
        {
            List<T> entityList = rw.DeSerializeObject<List<T>>(filePath);
            
            return entityList;
        }
        public T save(T entity)
        {
            List<T> entityList = getAll();
            //List<T> entityList = new List<T>();
            entityList.Add(entity);
            rw.SerializeObject<List<T>>(entityList, filePath);
            return entity;
        }

        public T set(T entity)
        {
            // TODO: implement
            return null;
        }


        public void delete(T entity)
        {
            // TODO: implement
        }

    }
}
