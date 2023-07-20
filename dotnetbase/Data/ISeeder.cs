namespace dotnetbase.Data;

public interface ISeeder
{
    Task SeedAsync(DataSeedContext context);
}