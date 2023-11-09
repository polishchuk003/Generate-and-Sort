using System.Data.Entity;

namespace Brighteye
{
    public class TestDBContext : DbContext
    {
        private const string ConnectionStringName = "TestDBContext";
        public TestDBContext() : base(ConnectionStringName)
        {
        }

        public DbSet<SortedData> SortedDatas { get; set; }
        public DbSet<UnsortedData> UnsortedDatas { get; set; }

    }

}
