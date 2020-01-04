using SampleData.Core;
using SampleData.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SampleData.UOW
{
    public class StudentUnitOfWork : UnitOfWork<SampleDbContext>
    {
        public StudentRepository Students { get; set; }
        public StudentUnitOfWork(string connectionString,string migrationAssemblyName)
            :base(connectionString, migrationAssemblyName)
        {
            Students = new StudentRepository(_dbContext);

        }
       
    }
}
