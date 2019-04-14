using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using TeknoLabs.Habit.Configuration;

namespace TeknoLabs.Habit.Web.Host.Startup
{
    [DependsOn(
       typeof(HabitWebCoreModule))]
    public class HabitWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public HabitWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(HabitWebHostModule).GetAssembly());
        }
    }
}
