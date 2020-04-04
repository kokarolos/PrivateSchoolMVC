using PrivateSchool.DatabaseLatest;
using PrivateSchool.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace PrivateSchool.Services
{
    public class CourseRepository 
    {
        public m_Database db = new m_Database();
        public IEnumerable<Course> GetCourses() => db.Courses.Include(x => x.Assignments).Include(x => x.Students).Include(x => x.Trainers).ToList();
        public Course GetCourse(int? id) => db.Courses.Find(id);
        public void Insert(object entity)
        {
            var course = entity as Course;
            db.Entry(course).State = EntityState.Added;
            db.SaveChanges();
        }

        public void Update(object entity,IEnumerable<int> selectedStudentsIds, IEnumerable<int> selectedTrainersIds, IEnumerable<int> selectedAssignemntsIds)
        {
            var course = entity as Course;

            db.Courses.Attach(course);
            db.Entry(course).Collection("Students").Load();
            db.Entry(course).Collection("Trainers").Load();
            db.Entry(course).Collection("Assignments").Load();
            course.Students.Clear();
            course.Trainers.Clear();
            course.Assignments.Clear();

            if(!((selectedAssignemntsIds == null)&&(selectedStudentsIds == null)&&(selectedTrainersIds == null)))
            {
                foreach (var id in selectedStudentsIds)
                {
                    Student student = db.Students.Find(id);
                    if(student != null)
                    {
                        course.Students.Add(student);
                    }
                }
                foreach (var id in selectedTrainersIds)
                {
                    Trainer trainer = db.Trainers.Find(id);
                    if (trainer != null)
                    {
                        course.Trainers.Add(trainer);
                    }
                }
                foreach (var id in selectedAssignemntsIds)
                {
                    Assignment assignment = db.Assignments.Find(id);
                    if (assignment != null)
                    {
                        course.Assignments.Add(assignment);
                    }
                }
            }


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

