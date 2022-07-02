namespace SkipIntro.Settings
{
    using UnityEngine;

    public class SkipIntroSetting : ToggleSettingDefinition
    {
        public SkipIntroSetting(OctDatGlobalInitializer initializer) : base(initializer)
        {
            this.id = "Oct.Settings.MySettings.SkipIntro";
            this.name = "Skip Intro";
            this.order = Main.SettingsCategory.settings.Count;
            this.category = Main.SettingsCategory;
            this.defaultValue = true;
        }

        public override void Apply()
        {
            KingdomManager.SkipIntro = (bool)this.GetValue();
            base.Apply();
        }

        public override Color LabelColor()
        {
            return Color.magenta;
        }
    }
}
