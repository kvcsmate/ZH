using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Persistence
{
    public class PersistenceDbContext: IdentityDbContext<User>
    {



        public PersistenceDbContext(DbContextOptions options) : base(options)
        {

        }
        public PersistenceDbContext()
        {

        }
    }
}
