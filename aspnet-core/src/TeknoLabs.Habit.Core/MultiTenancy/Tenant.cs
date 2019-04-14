using Abp.MultiTenancy;
using TeknoLabs.Habit.Authorization.Users;

namespace TeknoLabs.Habit.MultiTenancy
{
    public class Tenant : AbpTenant<User>
    {
        public Tenant()
        {            
        }

        public Tenant(string tenancyName, string name)
            : base(tenancyName, name)
        {
        }
    }
}
