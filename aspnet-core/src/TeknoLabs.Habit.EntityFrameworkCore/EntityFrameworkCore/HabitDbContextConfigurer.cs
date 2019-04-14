using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace TeknoLabs.Habit.EntityFrameworkCore
{
    public static class HabitDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<HabitDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<HabitDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
