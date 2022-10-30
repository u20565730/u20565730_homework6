
using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace u20565730_homework6.Models
{
    public class DBContext
    {
        public partial class BikeStoresEntities : DbContext
        {
            public BikeStoresEntities()
                : base("name=BikeStoresEntities")
            {
            }

            protected override void OnModelCreating(DbModelBuilder modelBuilder)
            {
                throw new UnintentionalCodeFirstException();
            }

            public virtual DbSet<brand> brands { get; set; }
            public virtual DbSet<category> categories { get; set; }
            public virtual DbSet<product> products { get; set; }
            public virtual DbSet<stock> stocks { get; set; }
            public virtual DbSet<customer> customers { get; set; }
            public virtual DbSet<order_items> order_items { get; set; }
            public virtual DbSet<order> orders { get; set; }
            public virtual DbSet<staff> staffs { get; set; }
            public virtual DbSet<store> stores { get; set; }
        }
    }
}