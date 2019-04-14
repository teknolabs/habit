using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using TeknoLabs.Habit.Roles.Dto;
using TeknoLabs.Habit.Users.Dto;

namespace TeknoLabs.Habit.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedUserResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();

        Task ChangeLanguage(ChangeUserLanguageDto input);
    }
}
