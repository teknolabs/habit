using System.Threading.Tasks;
using Abp.Application.Services;
using TeknoLabs.Habit.Authorization.Accounts.Dto;

namespace TeknoLabs.Habit.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
