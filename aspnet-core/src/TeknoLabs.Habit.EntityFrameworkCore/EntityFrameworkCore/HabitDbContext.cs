using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using TeknoLabs.Habit.Authorization.Roles;
using TeknoLabs.Habit.Authorization.Users;
using TeknoLabs.Habit.MultiTenancy;

namespace TeknoLabs.Habit.EntityFrameworkCore
{
    public class HabitDbContext : AbpZeroDbContext<Tenant, Role, User, HabitDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public HabitDbContext(DbContextOptions<HabitDbContext> options)
            : base(options)
        {
        }
    }
}
