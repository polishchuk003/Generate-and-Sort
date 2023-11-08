using Brighteye.Data;
using System;
using System.Data.Entity;
using System.Linq;

namespace Brighteye.DataModel
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
