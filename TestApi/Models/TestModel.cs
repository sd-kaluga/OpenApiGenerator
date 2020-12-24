//using Newtonsoft.Json;
//using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace TestApi.Models
{
    public class TestModel
    {
        public int IntValue { get; set; } = 123;

        public byte ByteValue { get; set; } = 0xFF;

        public double DoubleValue { get; set; } = 324.3432;

        public decimal DecimalValue { get; set; } = 123.32M;

        public bool BoolValue { get; set; } = true;

        public string Value { get; set; } = "sdfsdfsd";

        public List<int> ListInt { get; set; } = new List<int> { 1, 2, 3, 4, 5 };


        public SomeEnum EnumVal { get; set; } = SomeEnum.Val2;

        [JsonConverter(typeof(JsonStringEnumConverter))]
        public OtherEnum OtherEnumVal { get; set; } = OtherEnum.ValThree;

        public DateTime DateWithTime { get; set; } = DateTime.Now;

    }

    public enum SomeEnum
    {
        Val1,
        Val2,
        Val3
    }

    //  [JsonConverter(typeof(StringEnumConverter))]
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum OtherEnum
    {
        ValOne,
        ValTwo,
        ValThree
    }
}
