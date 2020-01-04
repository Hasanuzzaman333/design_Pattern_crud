using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VivaTest.Web.Entities;

namespace VivaTest.Web.Core.Repositories
{
    public class StudentTeacherRepository : Repository<StudentTeacher>, IStudentTeacherRepository
    {
        public StudentTeacherRepository(VivaContext vivaContext) : base(vivaContext)
        {

        }
    }
}
