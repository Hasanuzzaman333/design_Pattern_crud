using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace SampleData.MemberShip
{
    public class AccountContext : IdentityDbContext
    {
        public AccountContext(DbContextOptions<AccountContext> dbContextOptions)
            :base(dbContextOptions)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }




    }
}
