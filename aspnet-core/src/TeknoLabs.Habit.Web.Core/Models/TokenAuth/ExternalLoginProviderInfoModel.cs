using Abp.AutoMapper;
using TeknoLabs.Habit.Authentication.External;

namespace TeknoLabs.Habit.Models.TokenAuth
{
    [AutoMapFrom(typeof(ExternalLoginProviderInfo))]
    public class ExternalLoginProviderInfoModel
    {
        public string Name { get; set; }

        public string ClientId { get; set; }
    }
}
