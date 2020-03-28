using System;

namespace PrivateSchool.Services
{
    public interface IRepository: IDisposable
    {
        void Insert(Object entity);
        void Update(Object entity);
        void Delete(Object entity);
    }
}
