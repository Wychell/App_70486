using System.Data.Entity;
using System.Reflection;
using System.Data.Entity.ModelConfiguration.Configuration;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System;
using Web.Business.Entities;
using Web.Data.Mapping;

namespace Web.Data.Repositories
{
    public class WebDbContext : DbContext
    {
        public WebDbContext()
            :base("DefaultConneciton")
        {
            
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new PessoaMapping());
        }


        public DbSet<Pessoa> Pessoas { get; set; }
    }
}
