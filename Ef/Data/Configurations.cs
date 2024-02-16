namespace Ef.Data;

using Microsoft.EntityFrameworkCore;

public static class Configurations
{
   public static DbContextOptions<DataAccess> Options()
   {
      DbContextOptionsBuilder<DataAccess> configuration = new();
      configuration.UseSqlServer("Server=127.0.0.1;Database=Sources;User Id=sa;Password=senha;Integrated Security=true;MultipleActiveResultSets=true;TrustServerCertificate=True");
      return configuration.Options;
   }
}