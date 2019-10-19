using System;
using System.Runtime.Serialization;
using BinanceExchange.API.Converter;
using BinanceExchange.API.Models.WebSocket.Interfaces;
using Newtonsoft.Json;

namespace BinanceExchange.API.Models.WebSocket
{
    /// <summary>
    /// Data returned from the Binance WebSocket Kline endpoint
    /// </summary>
    [DataContract]
    public class BinanceKlineData: ISymbolWebSocketResponse
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

        [JsonProperty(PropertyName = "k")]
        [DataMember(Order = 4, Name = "k")]
        public BinanceKline Kline { get; set; }
    }
}
