﻿using PrivateSchool.DatabaseLatest;
using PrivateSchool.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace PrivateSchool.Services
{
    public class TrainerRepository
    {
        private m_Database db = new m_Database();
        public IEnumerable<Trainer> GetTrainers() => db.Trainers.ToList();
        public Trainer GetTrainer(int? id) => db.Trainers.Find(id);
        public void Insert(object entity)
        {
            var trainer = entity as Trainer;
            db.Entry(trainer).State = EntityState.Added;
            db.SaveChanges();
        }

        public void Update(object entity,IEnumerable<int> selectedCoursesId)
        {
            var trainer = entity as Trainer;
            db.Trainers.Attach(trainer);
            db.Entry(trainer).Collection("Courses").Load();
            trainer.Courses.Clear();
            db.SaveChanges();

            if(!(selectedCoursesId is null))
            {
                foreach (var id in selectedCoursesId)
                {
                    var course = db.Courses.Find(id);
                    if(course != null)
                    {
                        trainer.Courses.Add(course);
                    }
                }
                db.SaveChanges();
            }


            db.Entry(trainer).State = EntityState.Modified;
            db.SaveChanges();
        }

        public void Delete(object entity)
        {
            var trainer = entity as Trainer;
            db.Entry(trainer).State = EntityState.Deleted;
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
