using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VivaTest.Web.Core.Repositories;

namespace VivaTest.Web.Core.UOW
{
    public class UnitOfWork : IUnitOfWork 
    {
        private readonly VivaContext _dbContext;
        public StudentRepository StudentRepository { get; set; }
        public TeacherRepository TeacherRepository { get; set; }
        public StudentTeacherRepository StudentTeacherRepository { get; set; }

        public UnitOfWork(VivaContext vivaContext)
        {
            _dbContext = vivaContext;
            StudentRepository = new StudentRepository(_dbContext);
            TeacherRepository = new TeacherRepository(_dbContext);
            StudentTeacherRepository = new StudentTeacherRepository(_dbContext); 
        }
        public void Dispose()
        {
            _dbContext.Dispose();
        }

        public async Task SaveAsync()
        {
            await _dbContext.SaveChangesAsync();
        }

        public void Save()
        {
            _dbContext.SaveChangesAsync();
        }
    }
}
