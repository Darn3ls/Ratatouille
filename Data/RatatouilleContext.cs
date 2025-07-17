using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Ratatouille.Models;

namespace Ratatouille.Data
{
    public class RatatouilleContext : DbContext
    {
        public RatatouilleContext (DbContextOptions<RatatouilleContext> options)
            : base(options)
        {
        }

        public DbSet<Ratatouille.Models.Recipe> Recipe { get; set; } = default!;

        public DbSet<User> Users { get; set; } = default!;
    }
}
