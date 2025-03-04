using Microsoft.EntityFrameworkCore;
using Ratatouille.Data;

namespace Ratatouille.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
