using PrivateSchool.DatabaseLatest;
using PrivateSchool.Entities.Intermediaries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateSchool.Services
{
    public class StudentAssignmentRepository
    {
        private m_Database db = new m_Database();
        public IEnumerable<StudentAssignments> GetStudentAssignemnts() => db.StudentAssignments.ToList();
    }
}
