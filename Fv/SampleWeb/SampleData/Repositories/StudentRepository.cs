using SampleData.Core;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SampleData.Repositories
{
    public class StudentRepository : Repository<Student>
    {
        public StudentRepository(SampleDbContext sampleDbContext)
            :base(sampleDbContext)
        {

        }

        public async Task<Student> GetStudentAsync(Guid id)
        {
            var student = await dbSet.FindAsync(id);

            return student;
        }
    }
}
