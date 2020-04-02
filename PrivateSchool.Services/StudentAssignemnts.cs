using PrivateSchool.DatabaseLatest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrivateSchool.Entities.Intermediaries;

namespace PrivateSchool.Services
{
    public class StudentAssignemnts
    {
        private m_Database db = new m_Database();

        public IEnumerable<StudentAssignments> GetStudentAssignemnts() => db.StudentAssignments.ToList();
    }
}
