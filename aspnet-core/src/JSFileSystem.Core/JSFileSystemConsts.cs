using JSFileSystem.Debugging;

namespace JSFileSystem;

public class JSFileSystemConsts
{
    public const string LocalizationSourceName = "JSFileSystem";

    public const string ConnectionStringName = "Default";

    public const bool MultiTenancyEnabled = true;


    /// <summary>
    /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
    /// </summary>
    public static readonly string DefaultPassPhrase =
        DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "08f7f8f8c22d4fc7bafc386210fe8c96";
}
