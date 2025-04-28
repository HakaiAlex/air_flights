using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Infrastructure.Data;

public class ApplicationDbContextFactory
    : IDesignTimeDbContextFactory<ApplicationDbContext>
{
    public ApplicationDbContext CreateDbContext(string[] args)
    {
        // 1) Собираем конфигурацию, указывая, где искать appsettings.json
        var config = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json")
            .Build();

        // 2) Читаем строку подключения (имя должно совпадать с тем, что в appsettings.json)
        var cs = config.GetConnectionString("DefaultConnection");

        // 3) Настраиваем options и возвращаем контекст
        var builder = new DbContextOptionsBuilder<ApplicationDbContext>();
        builder.UseNpgsql(cs);

        return new ApplicationDbContext(builder.Options);
    }
}
