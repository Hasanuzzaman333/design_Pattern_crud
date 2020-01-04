using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VivaTest.Web.Entities;

namespace VivaTest.Web.Core.Repositories
{
    public class StudentRepository : Repository<Student>, IStudentRepository
    {
        public StudentRepository(VivaContext vivaContext) : base(vivaContext)
        {

        }
    }
}
