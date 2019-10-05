using System.Collections.Generic;
using System.Runtime.Serialization;

namespace BinanceExchange.API.Models.Response
{
    /// <summary>
    /// Response with account information associated with key
    /// </summary>
    [DataContract]
    public class FuturesAccountInformationResponse
    {

        [DataMember(Order = 8)]
        public List<FuturesBalanceResponse> Assets { get; set; }

        [DataMember(Order = 5)]
        public bool CanTrade { get; set; }

        [DataMember(Order = 6)]
        public bool CanWithdraw { get; set; }

        [DataMember(Order = 7)]
        public bool CanDeposit { get; set; }

        [DataMember(Order = 1)]
        public long FeeTier { get; set; }

        [DataMember(Order = 2)]
        public decimal MaxWithdrawAmount { get; set; }

        [DataMember(Order = 3)]
        public decimal TotalInitialMargin { get; set; }

        [DataMember(Order = 4)]
        public decimal TotalMaintMargin { get; set; }

        [DataMember(Order = 4)]
        public decimal TotalMarginBalance { get; set; }

        [DataMember(Order = 4)]
        public decimal TotalOpenOrderInitialMargin { get; set; }

        [DataMember(Order = 4)]
        public decimal TotalPositionInitialMargin { get; set; }

        [DataMember(Order = 4)]
        public decimal TotalUnrealizedProfit { get; set; }

        [DataMember(Order = 4)]
        public decimal TotalWalletBalance { get; set; }

        [DataMember(Order = 4)]
        public long UpdateTime { get; set; }

    }
}