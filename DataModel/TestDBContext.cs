using System.Data.Entity;

namespace Brighteye
{
    public class TestDBContext : DbContext
    {
        public TestDBContext()
            : base("name=TestDBContext")
        {
        }
        public DbSet<UnsortedData> UnsortedDatas { get; set; }
        public DbSet<SortedData> SortedDatas { get; set; }

    }

}
