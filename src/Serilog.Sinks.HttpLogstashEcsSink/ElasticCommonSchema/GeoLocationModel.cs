using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Serilog.ElasticCommonSchema
{
    [DataContract]
    public class GeoLocationModel
    {
        [DataMember]
        [JsonProperty("lat")]
        public double Latitude { get; set; }

        [DataMember]
        [JsonProperty("lon")]
        public double Longitude { get; set; }
    }
}