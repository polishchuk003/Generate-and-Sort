using System.Data.Entity;
using System.Xml.Linq;

namespace Brighteye
{
    public class DataDbContext : DbContext
    {
        public DataDbContext() : base("name = DataDbContext")
        {
        }

        public DbSet<SortedNumber> SortedNumbers { get; set; }
        public DbSet<UnsortedNumber> UnsortedNumbers { get; set; }

    }

}
