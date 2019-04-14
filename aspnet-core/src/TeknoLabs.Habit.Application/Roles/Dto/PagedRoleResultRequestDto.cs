using Abp.Application.Services.Dto;

namespace TeknoLabs.Habit.Roles.Dto
{
    public class PagedRoleResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}

