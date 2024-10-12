using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using azure_app_mc.Data;

    public class AppDdContext : DbContext
    {
        public AppDdContext (DbContextOptions<AppDdContext> options)
            : base(options)
        {
        }

        public DbSet<azure_app_mc.Data.Person> Person { get; set; } = default!;
    }
