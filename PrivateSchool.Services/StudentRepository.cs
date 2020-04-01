using System;
using System.Linq;
using System.Data.Entity;
using System.Collections.Generic;
using PrivateSchool.Database;
using PrivateSchool.Entities.Concrete;

namespace PrivateSchool.Services
{
    public class StudentRepository : IRepository
    {
        private m_Database db = new m_Database();
        public IEnumerable<Student> GetStudents() => db.Students.ToList();
        public Student GetStudent(int? id)=> db.Students.Find(id);
        public void Insert(object entity)
        {
            var student = entity as Student;
            db.Entry(student).State = EntityState.Added;
            db.SaveChanges();
        }

        public void Update(object entity)
        {
            var student = entity as Student;
            db.Entry(student).State = EntityState.Modified;
            db.SaveChanges();
        }

        public void Delete(object entity)
        {
            var student = entity as Student;
            db.Entry(student).State = EntityState.Deleted;
            db.SaveChanges();
        }

        private bool disposed = false;
        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    db.Dispose();
                }
                disposed = true;
            }
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
