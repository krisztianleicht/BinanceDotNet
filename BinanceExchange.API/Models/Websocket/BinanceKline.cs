using System;
using System.Runtime.Serialization;
using BinanceExchange.API.Converter;
using BinanceExchange.API.Enums;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace BinanceExchange.API.Models.WebSocket
{
    [DataContract]
    public class BinanceKline
    {
        [JsonProperty(PropertyName = "t")]
        [DataMember(Order = 1, Name = "t")]
        [JsonConverter(typeof(EpochTimeConverter))]
        public DateTime StartTime { get; set; }

        [JsonProperty(PropertyName = "T")]
        [DataMember(Order = 2, Name = "T")]
        [JsonConverter(typeof(EpochTimeConverter))]
        public DateTime EndTime { get; set; }

        [JsonProperty(PropertyName = "s")]
        [DataMember(Order = 3, Name = "s")]
        public string Symbol { get; set; }

        [JsonProperty(PropertyName = "i")]
        [DataMember(Order = 4, Name = "i")]
        [JsonConverter(typeof(StringEnumConverter))]
        public KlineInterval Interval { get; set; }

        [JsonProperty(PropertyName = "f")]
        [DataMember(Order = 5, Name = "f")]
        public long FirstTradeId { get; set; }

        [JsonProperty(PropertyName = "L")]
        [DataMember(Order = 6, Name = "L")]
        public long LastTradeId { get; set; }

        [JsonProperty(PropertyName = "o")]
        [DataMember(Order = 7, Name = "o")]
        public decimal Open { get; set; }

        [JsonProperty(PropertyName = "c")]
        [DataMember(Order = 8, Name = "c")]
        public decimal Close { get; set; }

        [JsonProperty(PropertyName = "h")]
        [DataMember(Order = 9, Name = "h")]
        public decimal High { get; set; }

        [JsonProperty(PropertyName = "l")]
        [DataMember(Order = 10, Name = "l")]
        public decimal Low { get; set; }

        [JsonProperty(PropertyName = "v")]
        [DataMember(Order = 11, Name = "v")]
        public decimal Volume { get; set; }

        [JsonProperty(PropertyName = "n")]
        [DataMember(Order = 12, Name = "n")]
        public int NumberOfTrades{ get; set; }

        [JsonProperty(PropertyName = "x")]
        [DataMember(Order = 13, Name = "x")]
        public bool IsBarFinal { get; set; }

        [JsonProperty(PropertyName = "q")]
        [DataMember(Order = 14, Name = "q")]
        public decimal QuoteVolume { get; set; }

        [JsonProperty(PropertyName = "V")]
        [DataMember(Order = 15, Name = "V")]
        public decimal VolumeOfActivyBuy { get; set; }

        [JsonProperty(PropertyName = "Q")]
        [DataMember(Order = 16, Name = "Q")]
        public decimal QuoteVolumeOfActivyBuy { get; set; }
    }
}