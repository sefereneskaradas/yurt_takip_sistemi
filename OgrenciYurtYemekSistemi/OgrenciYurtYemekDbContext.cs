using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;


namespace OgrenciYurtYemekSistemi
{
    internal class OgrenciYurtYemekDbContext : DbContext
    {
        public OgrenciYurtYemekDbContext()
         : base("name=OgrenciYurtYemekDbContext")
        {
        // Lazy loading disable
       this.Configuration.LazyLoadingEnabled = false;
        }

        public DbSet<OgrenciBilgileri> OgrenciBilgileri { get; set; }

        public DbSet<YurtBilgileri> YurtBilgileri { get; set; }

public DbSet<YemekBilgileri> YemekBilgileri { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
     // Pluralizing table name convention'ı devre dışı bırak
            modelBuilder.Conventions.Remove<System.Data.Entity.ModelConfiguration.Conventions.PluralizingTableNameConvention>();

  base.OnModelCreating(modelBuilder);
    }
    }
}