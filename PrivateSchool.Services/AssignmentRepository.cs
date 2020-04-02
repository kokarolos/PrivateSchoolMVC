using PrivateSchool.DatabaseLatest;
using PrivateSchool.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace PrivateSchool.Services
{
    public class AssignmentRepository
    {
        private m_Database db = new m_Database();
        public IEnumerable<Assignment> GetAssignments() => db.Assignments.ToList();
        public Assignment GetAssignment(int? id) => db.Assignments.Find(id);
        public void Insert(object entity)
        {
            var assignment = entity as Assignment;
            db.Entry(assignment).State = EntityState.Added;
            db.SaveChanges();
        }

        public void Update(object entity)
        {
            var assignment = entity as Assignment;
            db.Entry(assignment).State = EntityState.Modified;
            db.SaveChanges();
        }

        public void Delete(object entity)
        {
            var assignment = entity as Assignment;
            db.Entry(assignment).State = EntityState.Deleted;
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
