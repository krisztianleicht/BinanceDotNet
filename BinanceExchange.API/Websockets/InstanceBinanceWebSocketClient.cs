using BinanceExchange.API.Client.Interfaces;
using BinanceExchange.API.Serialization;
using log4net;

namespace BinanceExchange.API.Websockets
{
    /// <summary>
    /// Used for manual management of WebSockets per instance. Only use this if you want to manually manage, open, and close your websockets.
    /// </summary>
    public class InstanceBinanceWebSocketClient : AbstractBinanceWebSocketClient, IBinanceWebSocketClient
    {
        public InstanceBinanceWebSocketClient(IBinanceClient binanceClient, ILog logger = null, ISerializationHandler serializationHandler = null) :
            base(binanceClient, logger, serializationHandler)
        {
        }
    }
}