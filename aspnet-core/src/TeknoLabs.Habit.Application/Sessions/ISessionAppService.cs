using System.Threading.Tasks;
using Abp.Application.Services;
using TeknoLabs.Habit.Sessions.Dto;

namespace TeknoLabs.Habit.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
