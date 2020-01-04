using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace FinalExam
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = CreateWebHostBuilder(args).Build();
            using (var services = host.Services.CreateScope())
            {
                var dbContext = services.ServiceProvider.GetRequiredService<DemoContext>();
                var userMgr = services.ServiceProvider.GetRequiredService<UserManager<IdentityUser>>();
                var roleMgr = services.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();

                dbContext.Database.Migrate();

                var teacherRole = new IdentityRole("Teacher");
                var studentRole = new IdentityRole("Student");

                if (dbContext.Roles.Count() < 2)
                {
                    roleMgr.CreateAsync(teacherRole).GetAwaiter().GetResult();
                    roleMgr.CreateAsync(studentRole).GetAwaiter().GetResult();
                }

                if (!dbContext.Users.Any(u => u.UserName == "Teacher"))
                {
                    var teacher = new IdentityUser
                    {
                        UserName = "teacher@test.com",
                        Email = "teacher@test.com"
                    };
                    var result = userMgr.CreateAsync(teacher, "password").GetAwaiter().GetResult();
                    userMgr.AddToRoleAsync(teacher, teacherRole.Name).GetAwaiter().GetResult();
                }
                if (!dbContext.Users.Any(u => u.UserName == "student"))
                {
                    var student = new IdentityUser
                    {
                        UserName = "student@test.com",
                        Email = "student@test.com"
                    };
                    var result = userMgr.CreateAsync(student, "password").GetAwaiter().GetResult();
                    userMgr.AddToRoleAsync(student, studentRole.Name).GetAwaiter().GetResult();
                }

            }
            host.Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
