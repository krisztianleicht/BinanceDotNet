using System;
using System.Runtime.Serialization;
using BinanceExchange.API.Converter;
using BinanceExchange.API.Models.WebSocket.Interfaces;
using Newtonsoft.Json;

namespace BinanceExchange.API.Models.WebSocket
{
    /// <summary>
    /// Aggregate trade data response from Trades websocket endpoint
    /// </summary>
    [DataContract]
    public class BinanceAggregateTradeData : ISymbolWebSocketResponse
    {
        [JsonProperty(PropertyName = "e")]
        [DataMember(Order = 1, Name = "e")]
        public string EventType { get; set; }

        [JsonProperty(PropertyName = "E")]
        [DataMember(Order = 2, Name = "E")]
        [JsonConverter(typeof(EpochTimeConverter))]
        public DateTime EventTime { get; set; }

        [JsonProperty(PropertyName = "s")]
        [DataMember(Order = 3, Name = "s")]
        public string Symbol { get; set; }

        [DataMember(Order = 4, Name = "a")]
        [JsonProperty(PropertyName = "a")]
        public long AggregateTradeId { get; set; }

        [DataMember(Order = 2, Name = "p")]
        [JsonProperty(PropertyName = "p")]
        public decimal Price { get; set; }

        [DataMember(Order = 3, Name = "q")]
        [JsonProperty(PropertyName = "q")]
        public decimal Quantity { get; set; }

        [DataMember(Order = 4, Name = "f")]
        [JsonProperty(PropertyName = "f")]
        public long FirstTradeId { get; set; }

        [DataMember(Order = 5, Name = "l")]
        [JsonProperty(PropertyName = "l")]
        public long LastTradeId { get; set; }

        [DataMember(Order = 6, Name = "T")]
        [JsonProperty(PropertyName = "T")]
        [JsonConverter(typeof(EpochTimeConverter))]
        public DateTime TradeTime { get; set; }

        [DataMember(Order = 7, Name = "m")]
        [JsonProperty(PropertyName = "m")]
        public bool WasBuyerMaker { get; set; }

        [DataMember(Order = 7, Name = "M")]
        [JsonProperty(PropertyName = "M")]
        public bool WasBestPriceMatch { get; set; }
    }
}