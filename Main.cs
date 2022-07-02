namespace SkipIntro
{
    using SkipIntro.Settings;

    public class Main: BaseManager
    {
        internal static readonly SettingsCategory SettingsCategory;
        static Main()
        {
            SettingsCategory = Manager<SettingsManager>.Instance.globalSettingsCategories.Find(x => x.id == "MrPurple6411_Settings");
            if (SettingsCategory == null)
            {
                SettingsCategory = new SettingsCategory(new OctDatGlobalInitializer())
                {
                    id = "MrPurple6411_Settings",
                    name = "MrPurple's Mod Settings",
                    canReset = true,
                    global = true,
                    order = -1000
                };
                SettingsCategory.PostInit();
            }
            SettingsCategory.AddSetting(new SkipIntroSetting(new OctDatGlobalInitializer()));
        }
    }
}
