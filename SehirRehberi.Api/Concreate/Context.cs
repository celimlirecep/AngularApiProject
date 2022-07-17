using Microsoft.EntityFrameworkCore;
using SehirRehberi.Api.Model;



namespace SehirRehberi.Api.Concreate
{
    public class Context:DbContext
    {
        public Context(DbContextOptions options):base(options)
        {

        }
        public DbSet<Value> Values { get; set; }

    }
}
