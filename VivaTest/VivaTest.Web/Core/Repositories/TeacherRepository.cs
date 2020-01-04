using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VivaTest.Web.Entities;

namespace VivaTest.Web.Core.Repositories
{
    public class TeacherRepository : Repository<Teacher>, ITeacherRepository
    {
        public TeacherRepository(VivaContext vivaContext) : base(vivaContext)
        {

        }
    }
}
