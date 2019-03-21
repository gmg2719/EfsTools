using System;
using System.ComponentModel;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(1632)]
    [Attributes(9)]
    public class Bc1TxComp1I
    {
        [ElementsCount(32)]
        [ElementType("int8")]
        [Description("")]
        public sbyte[] Value { get; set; }
        
    }
}