using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Api.Data.Context;

public class ContextFactory : IDesignTimeDbContextFactory<AppDbContext>
{
    public AppDbContext CreateDbContext(string[] args)
    {
        //var connectionString = "Server=localhost;DataBase=SHC_API_DB;Uid=valentim;Pwd=123456";
        var connectionString = "Data Source=valentim\\sqlexpress;Initial Catalog=SHC_API_DB;Integrated Security=True;TrustServerCertificate=True;";
        var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
        optionsBuilder.UseSqlServer(connectionString);
        return new AppDbContext(optionsBuilder.Options);
    }
}
