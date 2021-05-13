using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using Protocols.Libs.Models.Protocols;

namespace Protocols.Libs.Framework
{
    [DbConfigurationType(typeof(MySql.Data.EntityFramework.MySqlEFConfiguration))]
    public class MyContext : DbContext
    {
        public DbSet<Protocol> Protocol { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }

}
