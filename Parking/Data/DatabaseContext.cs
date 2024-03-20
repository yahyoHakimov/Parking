using Microsoft.EntityFrameworkCore;

namespace Parking.Data
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext (DbContextOptions options) : base (options)
        {

        }


    }
}
