using System.Collections.Generic;

namespace TeknoLabs.Habit.Authentication.External
{
    public interface IExternalAuthConfiguration
    {
        List<ExternalLoginProviderInfo> Providers { get; }
    }
}
