using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace JSFileSystem.Localization;

public static class JSFileSystemLocalizationConfigurer
{
    public static void Configure(ILocalizationConfiguration localizationConfiguration)
    {
        localizationConfiguration.Sources.Add(
            new DictionaryBasedLocalizationSource(JSFileSystemConsts.LocalizationSourceName,
                new XmlEmbeddedFileLocalizationDictionaryProvider(
                    typeof(JSFileSystemLocalizationConfigurer).GetAssembly(),
                    "JSFileSystem.Localization.SourceFiles"
                )
            )
        );
    }
}
