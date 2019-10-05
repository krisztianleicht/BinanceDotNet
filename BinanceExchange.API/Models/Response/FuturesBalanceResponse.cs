using System.Runtime.Serialization;

namespace BinanceExchange.API.Models.Response
{
    /// <summary>
    /// Balance response providing information on assets
    /// </summary>
    [DataContract]
    public class FuturesBalanceResponse
    {
        [DataMember(Order = 1)]
        public string Asset { get; set; }

        [DataMember(Order = 2)]
        public decimal InitialMargin { get; set; }

        [DataMember(Order = 3)]
        public decimal MaintMargin { get; set; }

        [DataMember(Order = 4)]
        public decimal MarginBalance { get; set; }

        [DataMember(Order = 5)]
        public decimal MaxWithdrawAmount { get; set; }

        [DataMember(Order = 6)]
        public decimal OpenOrderInitialMargin { get; set; }

        [DataMember(Order = 7)]
        public decimal PositionInitialMargin { get; set; }

        [DataMember(Order = 8)]
        public decimal UnrealizedProfit { get; set; }

        [DataMember(Order = 9)]
        public decimal WalletBalance { get; set; }
    }
}