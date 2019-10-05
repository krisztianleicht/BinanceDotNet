using System.Runtime.Serialization;

namespace BinanceExchange.API.Models.Response
{
    /// <summary>
    /// Balance response providing information on assets
    /// </summary>
    [DataContract]
    public class MarginBalanceResponse
    {
        [DataMember(Order = 1)]
        public string Asset { get; set; }

        [DataMember(Order = 2)]
        public decimal Borrowed { get; set; }

        [DataMember(Order = 3)]
        public decimal Free { get; set; }

        [DataMember(Order = 4)]
        public decimal Interest { get; set; }

        [DataMember(Order = 5)]
        public decimal Locked { get; set; }

        [DataMember(Order = 6)]
        public decimal NetAsset { get; set; }
    }
}