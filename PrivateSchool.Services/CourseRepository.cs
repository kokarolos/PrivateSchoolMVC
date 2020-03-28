using PrivateSchool.Database;
using PrivateSchool.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateSchool.Services
{
    public class CourseRepository :IRepository
    {
        public m_Database db = new m_Database();
        public IEnumerable<Course> GetCourses() => db.Course.ToList();
        public Course GetCourse(int? id) => db.Course.Find(id);
        public void Insert(object entity)
        {
            var course = entity as Course;
            db.Entry(course).State = EntityState.Added;
            db.SaveChanges();
        }

        public void Update(object entity)
        {
            var course = entity as Course;
            db.Entry(course).State = EntityState.Modified;
            db.SaveChanges();
        }

        public void Delete(object entity)
        {
            var course = entity as Course;
            db.Entry(course).State = EntityState.Deleted;
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

