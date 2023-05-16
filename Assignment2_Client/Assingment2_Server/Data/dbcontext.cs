using Microsoft.EntityFrameworkCore;
using sharedModel;
namespace Assingment2_Server.Data
{
    public class dbcontext
    {
        public dbcontext(DbContextOptions<dbcontext> options): base(options) { }

        public DbSet<StdClass> stdClasses { get; set; }
    }
}
