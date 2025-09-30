using hospitalproject.Models;
using Microsoft.EntityFrameworkCore;

namespace hospitalproject.Controllers
{
    public class ApplicationDbContext:DbContext
    {public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<patient> patient {  get; set; }
    }
}
