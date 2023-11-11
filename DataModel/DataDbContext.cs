using System.Data.Entity;
using System.Xml.Linq;

namespace Brighteye
{
    public class DataDbContext : DbContext
    {
        // private const string connectionStringName = "DataDbContext";
        public DataDbContext() : base("name = DataDbContext")
        {
        }

        public DbSet<SortedNumber> SortedNumbers { get; set; }
        public DbSet<UnsortedNumber> UnsortedNumbers { get; set; }

    }

}
