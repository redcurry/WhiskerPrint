using System.Configuration;

namespace WhiskerPrint.PresentationLayer
{
    public class OptionsSettings : ApplicationSettingsBase
    {
        [UserScopedSetting()]
        [DefaultSettingValue("true")]
        public bool UseCascader
        {
            get { return (bool)this["UseCascader"]; }
            set { this["UseCascader"] = value; }
        }

        [UserScopedSetting()]
        [DefaultSettingValue("0.0")]
        public double CascaderThreshold
        {
            get { return (double)this["CascaderThreshold"]; }
            set { this["CascaderThreshold"] = value; }
        }

        [UserScopedSetting()]
        [DefaultSettingValue("0")]
        public int CascaderQualityLevelCount
        {
            get { return (int)this["CascaderQualityLevelCount"]; }
            set { this["CascaderQualityLevelCount"] = value; }
        }

        [UserScopedSetting()]
        [DefaultSettingValue("0")]
        public int CascaderSkipsPerQualityLevel
        {
            get { return (int)this["CascaderSkipsPerQualityLevel"]; }
            set { this["CascaderSkipsPerQualityLevel"] = value; }
        }

        [UserScopedSetting()]
        [DefaultSettingValue("true")]
        public bool UseShifter
        {
            get { return (bool)this["UseShifter"]; }
            set { this["UseShifter"] = value; }
        }

        [UserScopedSetting()]
        [DefaultSettingValue("0")]
        public int ShifterOffset
        {
            get { return (int)this["ShifterOffset"]; }
            set { this["ShifterOffset"] = value; }
        }

        [UserScopedSetting()]
        [DefaultSettingValue("0")]
        public int ShifterSteps
        {
            get { return (int)this["ShifterSteps"]; }
            set { this["ShifterSteps"] = value; }
        }
    }
}
