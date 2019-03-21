using System;
using System.ComponentModel;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024135", true, 0xE1FF)]
    [Attributes(9)]
    public class TdscdmaB40LnaRangeRiseFallWbModeAcq2I
    {
        [ElementsCount(12)]
        [ElementType("uint8")]
        [Description("")]
        public byte[] Value { get; set; }
        
    }
}