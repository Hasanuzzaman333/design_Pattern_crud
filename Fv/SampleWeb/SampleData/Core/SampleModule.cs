using Autofac;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using SampleData.Models;
using SampleData.Services;
using SampleData.UOW;
using System;
using System.Collections.Generic;
using System.Text;

namespace SampleData.Core
{
    public class SampleModule : Module
    {
        private readonly string _connectionString;
        private readonly string _migrationAssemblyName;

        public SampleModule(IConfiguration configuration,string connectionStringName,string migrationAssemblyName)
        {
            _connectionString = configuration.GetConnectionString(connectionStringName);
            _migrationAssemblyName = migrationAssemblyName;
        }

        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<UserManager<IdentityUser>>();
            builder.RegisterType<SignInManager<IdentityUser>>();

            builder.RegisterType<SampleDbContext>().
                WithParameter("connectionString", _connectionString).
                WithParameter("migrationAssemblyName", _migrationAssemblyName)
                .SingleInstance();

            builder.RegisterType<StudentUnitOfWork>().
                WithParameter("connectionString", _connectionString).
                WithParameter("migrationAssemblyName", _migrationAssemblyName)
                .InstancePerDependency();
                

            builder.RegisterType<StudentModel>();

            builder.RegisterType<StudentService>()
                .As<IStudentService>()
                .SingleInstance();

            base.Load(builder);
        }
    }
}
