using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace Formulariobonocovidjb.Data{

    public class DatabaseContext : DbContext{

        public DatabaseContext(DbContextOptions<DatabaseContext> options)
            : base(options)
        {
        }
        public DbSet<Formulariobonocovidjb.Models.Covid> Covid { get; set; }
    }
}