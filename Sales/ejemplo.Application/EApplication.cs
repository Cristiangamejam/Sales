using ejemplo.Abstractions;
using ejemplo.Repository;
using System;
using System.Collections.Generic;

namespace ejemplo.EApplication
{
    public interface IEApplication<T> : ICrud<T>
    {

    }

    public class EApplication<T> : IEApplication<T> where T : IEntity
    {
        IRepository<T> _repository;
        public EApplication(IRepository<T> repository)
        {
            _repository = repository;
        }

        public void Delete(int id)
        {
            _repository.Delete(id);
        }

        public IList<T> GetAll()
        {
            return _repository.GetAll();
        }

        public T GetById(int id)
        {
            return _repository.GetById(id);
        }

        public T Save(T entity)
        {
            return _repository.Save(entity);
        }
    }
}
