using EndlessShop.Debugging;

namespace EndlessShop
{
    public class EndlessShopConsts
    {
        public const string LocalizationSourceName = "EndlessShop";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "68a8ae9cdb5b42a4a58371ac9a77fa71";
    }
}
