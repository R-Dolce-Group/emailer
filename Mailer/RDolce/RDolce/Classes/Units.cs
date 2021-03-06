﻿// <auto-generated />
//
// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using QuickType;
//
//    var units = Units.FromJson(jsonString);

namespace RDolce
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class Unit
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("createdTime")]
        public DateTimeOffset CreatedTime { get; set; }

        [JsonProperty("fields")]
        public UnitFields Fields { get; set; }
    }

    public partial class UnitFields
    {
        [JsonProperty("ID")]
        public string Id { get; set; }

        public string unitId { get; set; }

        [JsonProperty("Building")]
        public string[] Building { get; set; }

        [JsonProperty("Address")]
        public string Address { get; set; }

        [JsonProperty("City")]
        public string City { get; set; }

        [JsonProperty("Zip")]
      //  [JsonConverter(typeof(ParseStringConverter))]
        public string Zip { get; set; }

        [JsonProperty("Field 22")]
        public string Field22 { get; set; }

        [JsonProperty("Description")]
        public string Description { get; set; }

        [JsonProperty("Sleeps")]
      //  [JsonConverter(typeof(ParseStringConverter))]
        public string Sleeps { get; set; }

        [JsonProperty("Bedrooms")]
      //  [JsonConverter(typeof(ParseStringConverter))]
        public string Bedrooms { get; set; }

        [JsonProperty("Baths")]
     //   [JsonConverter(typeof(ParseStringConverter))]
        public string Baths { get; set; }

        [JsonProperty("PropertyType")]
        public string PropertyType { get; set; }

        [JsonProperty("State")]
        public string State { get; set; }

        [JsonProperty(" Annual Rent ")]
        public string AnnualRent { get; set; }

        [JsonProperty(" Seasonal Jan - Mar ")]
        public string SeasonalJanMar { get; set; }

        [JsonProperty(" Off Seasonal April - Dec ")]
        public string OffSeasonalAprilDec { get; set; }

        [JsonProperty(" Standard Seasonal weekly  ")]
        public string StandardSeasonalWeekly { get; set; }

        [JsonProperty(" Standard Seasonal daily ")]
        public string StandardSeasonalDaily { get; set; }

        [JsonProperty(" Off Seasonal weekly ")]
        public string OffSeasonalWeekly { get; set; }

        [JsonProperty(" Off Seasonal daily")]
        public string OffSeasonalDaily { get; set; }

        [JsonProperty("Table 6 2")]
        public string Table62 { get; set; }

        [JsonProperty("HOA Communities copy")]
        public string[] HoaCommunitiesCopy { get; set; }
    }

    public partial class Unit
    {
        public static Unit FromJson(string json) => JsonConvert.DeserializeObject<Unit>(json, ConverterUnit.Settings);
    }

    public static class SerializeUnit
    {
        public static string ToJson(this Unit self) => JsonConvert.SerializeObject(self, ConverterUnit.Settings);
    }

    internal static class ConverterUnit
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }

    internal class ParseUnitConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(long) || t == typeof(long?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            long l;
            if (Int64.TryParse(value, out l))
            {
                return l;
            }
            throw new Exception("Cannot unmarshal type long");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (long)untypedValue;
            serializer.Serialize(writer, value.ToString());
            return;
        }

        public static readonly ParseStringConverter Singleton = new ParseStringConverter();
    }
}
