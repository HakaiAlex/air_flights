namespace Infrastructure.Data;

public class ApplicationDbContextInitializer
{
    public static void Initialize(ApplicationDbContext context) => context.Database.EnsureCreated();
}
