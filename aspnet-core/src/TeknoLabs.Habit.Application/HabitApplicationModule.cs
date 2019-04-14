using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using TeknoLabs.Habit.Authorization;

namespace TeknoLabs.Habit
{
    [DependsOn(
        typeof(HabitCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class HabitApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<HabitAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(HabitApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)
            );
        }
    }
}
