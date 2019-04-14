using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using TeknoLabs.Habit.Configuration;
using TeknoLabs.Habit.Web;

namespace TeknoLabs.Habit.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class HabitDbContextFactory : IDesignTimeDbContextFactory<HabitDbContext>
    {
        public HabitDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<HabitDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            HabitDbContextConfigurer.Configure(builder, configuration.GetConnectionString(HabitConsts.ConnectionStringName));

            return new HabitDbContext(builder.Options);
        }
    }
}
