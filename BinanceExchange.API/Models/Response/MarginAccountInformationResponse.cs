using System.Collections.Generic;
using System.Runtime.Serialization;

namespace BinanceExchange.API.Models.Response
{
    /// <summary>
    /// Response with account infromation associated with key
    /// </summary>
    [DataContract]
    public class MarginAccountInformationResponse
    {
        [DataMember(Order = 1)]
        public bool BorrowEnabled { get; set; }

        [DataMember(Order = 2)]
        public decimal MarginLevel { get; set; }

        [DataMember(Order = 3)]
        public decimal TotalAssetOfBtc { get; set; }

        [DataMember(Order = 4)]
        public decimal TotalLiabilityOfBtc { get; set; }

        [DataMember(Order = 5)]
        public decimal TotalNetAssetOfBtc { get; set; }

        [DataMember(Order = 6)]
        public bool TradeEnabled { get; set; }

        [DataMember(Order = 7)]
        public bool TransferEnabled { get; set; }

        [DataMember(Order = 8)]
        public List<BalanceResponse> UserAssets { get; set; }
    }
}