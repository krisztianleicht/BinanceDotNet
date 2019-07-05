using BinanceExchange.API.Models.WebSocket.Interfaces;
using System;
using System.Runtime.Serialization;

namespace BinanceExchange.API.Models.WebSocket
{
    [DataContract]
    public class CombinedBinanceKlineData : IWebSocketResponse
    {
        [DataMember(Order = 1, Name = "stream")]
        public string Stream;

        [DataMember(Order = 2, Name = "data")]
        public BinanceKlineData Data;

        [IgnoreDataMember]
        public string EventType { get; set; }
        [IgnoreDataMember]
        public DateTime EventTime { get; set; }
    }
}
