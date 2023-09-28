using Microsoft.EntityFrameworkCore;

namespace ClassCode.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {

        }


    }
}
