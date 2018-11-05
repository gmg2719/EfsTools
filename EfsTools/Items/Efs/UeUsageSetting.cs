using System;
using System.ComponentModel;
using EfsTools.Attributes;
using Newtonsoft.Json;

namespace EfsTools.Items.Efs
{
    public enum UeUsageSettingValue : byte
    {
        None = byte.MaxValue,
        VoiceCentric = 0,
        DataCentric = 1
    }
    
    [Serializable]
    [EfsFile("/nv/item_files/modem/mmode/ue_usage_setting", true, 0xE1FF)]
    [Attributes(9)]
    public class UeUsageSetting
    {
        [JsonIgnore]
        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte Value { get; set; }

        public string ValueString
        {
            get => $"{(UeUsageSettingValue) Value}";
            set => Value = (byte) Enum.Parse(typeof(UeUsageSettingValue), value);
        }
    }
}