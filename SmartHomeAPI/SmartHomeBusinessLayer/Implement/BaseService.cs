using SmartHomeBusinessLayer.Define;
using SmartHomeDataAccessLayer.Repository.Define;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace SmartHomeBusinessLayer.Implement
{
    public class BaseService<T> : IBaseService<T> where T : class
    {
        protected readonly IUnitOfWork iUnitOfWork;
        protected IRepository<T> iRepository;

        public BaseService(IUnitOfWork unitOfWork)
        {
            this.iUnitOfWork = unitOfWork;
            this.iRepository = unitOfWork.GetRepository<T>();
        }
        public virtual T Add(T entity)
        {
            return iRepository.Add(entity);
        }

        public virtual void Update(T entity)
        {
            iRepository.Update(entity);
        }

        public virtual T Delete(T entity)
        {
            return iRepository.Delete(entity);
        }

        public virtual T Delete(int id)
        {
            return iRepository.Delete(id);
        }

        public virtual void DeleteMulti(Expression<Func<T, bool>> where)
        {
            iRepository.DeleteMulti(where);
        }

        public virtual T GetSingleById(int id)
        {
            return iRepository.GetSingleById(id);
        }

        //public virtual IEnumerable<T> GetMany(Expression<Func<T, bool>> where, string includes)
        //{
        //}

        public virtual int Count(Expression<Func<T, bool>> where)
        {
            return iRepository.Count(where);
        }

        public IEnumerable<T> GetAll(string[] includes = null)
        {
            return iRepository.GetAll(includes);
        }

        public T GetSingleByCondition(Expression<Func<T, bool>> expression, string[] includes = null)
        {
            return iRepository.GetSingleByCondition(expression, includes);
        }

        public virtual IEnumerable<T> GetMulti(Expression<Func<T, bool>> predicate, string[] includes = null)
        {
            return iRepository.GetMulti(predicate, includes);
        }

        public virtual IEnumerable<T> GetMultiPaging(Expression<Func<T, bool>> predicate, out int total, int index = 0, int size = 20, string[] includes = null)
        {
            return iRepository.GetMultiPaging(predicate, out total, index = 0, size = 50, includes);
        }

        public bool CheckContains(Expression<Func<T, bool>> predicate)
        {
            return iRepository.CheckContains(predicate);

        }

        public void SaveChange()
        {
            iUnitOfWork.Save();
        }
    }
}
