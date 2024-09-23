// Set up the service provider and DbContext
using EFDatabase;
using EFDatabase.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;



// Set up configuration to load the appsettings.json file
var configuration = new ConfigurationBuilder()
    .SetBasePath(Directory.GetCurrentDirectory())
    .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
    .Build();


var serviceProvider = new ServiceCollection()
    .AddDbContext<ECDbContext>(options =>
    options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")))
    .BuildServiceProvider();

// Get an instance of the DbContext and ensure database creation/migration
using (var context = serviceProvider.GetRequiredService<ECDbContext>())
{
// Ensure database creation
    context.Database.Migrate(); // Ensures migrations are applied
}

Console.WriteLine("Migration complete!");
