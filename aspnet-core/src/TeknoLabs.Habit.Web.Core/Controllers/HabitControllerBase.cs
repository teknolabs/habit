using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace TeknoLabs.Habit.Controllers
{
    public abstract class HabitControllerBase: AbpController
    {
        protected HabitControllerBase()
        {
            LocalizationSourceName = HabitConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
