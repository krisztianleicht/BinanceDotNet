using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BinanceExchange.API.Serialization
{
    public class NewtonsoftSerializationHandler : ISerializationHandler
    {
        public T DeserializeObject<T>(string data)
        {
            return JsonConvert.DeserializeObject<T>(data);
        }

        public T DeserializeObject<T>(byte[] data)
        {
            return JsonConvert.DeserializeObject<T>(Encoding.UTF8.GetString(data));
        }
    }
}
