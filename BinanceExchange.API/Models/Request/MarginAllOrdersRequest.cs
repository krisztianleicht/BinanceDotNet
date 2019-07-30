using BinanceExchange.API.Converter;
using BinanceExchange.API.Models.Request.Interfaces;
using Newtonsoft.Json;
using System;
using System.Runtime.Serialization;

namespace BinanceExchange.API.Models.Request
{
    /// <summary>
    /// Request object used to retrieve all Binance orders
    /// </summary>
    [DataContract]
    public class MarginAllOrdersRequest : IRequest
    {
        [DataMember(Order = 1)]
        public string Symbol { get; set; }

        [DataMember(Order = 2)]
        public long? OrderId { get; set; }

        [DataMember(Order = 3)]
        public int? Limit { get; set; }

        [DataMember(Order = 4)]
        [JsonConverter(typeof(EpochTimeConverter))]
        public DateTime? StartTime { get; set; }

        [DataMember(Order = 5)]
        [JsonConverter(typeof(EpochTimeConverter))]
        public DateTime? EndTime { get; set; }
    }
}
