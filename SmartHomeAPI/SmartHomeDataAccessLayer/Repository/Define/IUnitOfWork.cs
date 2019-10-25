﻿namespace SmartHomeDataAccessLayer.Repository.Define
{
    public interface IUnitOfWork
    {
        IRepository<T> GetRepository<T>() where T : class;

        void Save();
    }
}
