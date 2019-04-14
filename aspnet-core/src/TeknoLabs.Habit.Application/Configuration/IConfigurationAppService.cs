using System.Threading.Tasks;
using TeknoLabs.Habit.Configuration.Dto;

namespace TeknoLabs.Habit.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
