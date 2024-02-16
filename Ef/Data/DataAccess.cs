namespace Ef.Data;

using Ef.Models;
using Ef.Models.Maps;
using Microsoft.EntityFrameworkCore;

public sealed class DataAccess(DbContextOptions<DataAccess> options) : DbContext(options)
{
   public DbSet<People> Peoples { get; set; }
   protected override void OnModelCreating(ModelBuilder modelBuilder)
   {
      modelBuilder.ApplyConfiguration(new PeopleMap());
   }

}