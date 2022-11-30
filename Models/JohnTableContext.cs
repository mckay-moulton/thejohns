using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace thejohns.Models
{
    public class JohnTableContext :DbContext
    
    {
        protected readonly IConfiguration Configuration;
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public JohnTableContext(IConfiguration configuration)
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        {
            Configuration = configuration;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            // connect to sql server with connection string from app settings
            //options.UseMySql(Configuration.GetConnectionString("MoviesDbConnection"));
            options.UseMySql(Configuration.GetConnectionString("JohnConnection"), new MySqlServerVersion(new Version(8, 0, 28)));
        }
        public virtual DbSet<JohnTable> JohnTable { get; set; }
    }
}