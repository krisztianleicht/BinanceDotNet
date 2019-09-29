using System;
using System.Runtime.Serialization;
using BinanceExchange.API.Models.WebSocket.Interfaces;

namespace BinanceExchange.API.Models.WebSocket
{
    [DataContract]
    public class CombinedBinanceAggregateTradeData : IWebSocketResponse
    {
        [DataMember(Order = 1, Name = "stream")]
        public string Stream;

        [DataMember(Order = 2, Name = "data")]
        public BinanceAggregateTradeData Data;

        [IgnoreDataMember]
        public string EventType { get; set; }
        [IgnoreDataMember]
        public DateTime EventTime { get; set; }
    }
}