using Abp.Authorization;
using TeknoLabs.Habit.Authorization.Roles;
using TeknoLabs.Habit.Authorization.Users;

namespace TeknoLabs.Habit.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
