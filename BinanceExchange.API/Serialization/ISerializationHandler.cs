using System;
using System.IO;
using WebSocketSharp;

namespace BinanceExchange.API.Serialization
{
    public interface ISerializationHandler
    {

        T DeserializeObject<T>(string data);
        T DeserializeObject<T>(byte[] data);
    }

}
