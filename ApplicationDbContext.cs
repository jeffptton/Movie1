using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConnectionsTest1.Model
{
    public class ApplicationDbContext :DbContext
    {
        internal object myConnections;

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

     
        }
        // creqate a DB Set property to add connections to database
        public DbSet<Connections> ConnectionsItems { get; set; }
        // **this property is a table in your database 
    }

}
