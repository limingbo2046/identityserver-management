using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace lcn.identityserver_management.EntityFrameworkCore
{
    public class identityserver_managementHttpApiHostMigrationsDbContextFactory : IDesignTimeDbContextFactory<identityserver_managementHttpApiHostMigrationsDbContext>
    {
        public identityserver_managementHttpApiHostMigrationsDbContext CreateDbContext(string[] args)
        {
            var configuration = BuildConfiguration();

            var builder = new DbContextOptionsBuilder<identityserver_managementHttpApiHostMigrationsDbContext>()
                .UseSqlServer(configuration.GetConnectionString("identityserver_management"));

            return new identityserver_managementHttpApiHostMigrationsDbContext(builder.Options);
        }

        private static IConfigurationRoot BuildConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false);

            return builder.Build();
        }
    }
}
