using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace TeknoLabs.Habit.Localization
{
    public static class HabitLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(HabitConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(HabitLocalizationConfigurer).GetAssembly(),
                        "TeknoLabs.Habit.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
