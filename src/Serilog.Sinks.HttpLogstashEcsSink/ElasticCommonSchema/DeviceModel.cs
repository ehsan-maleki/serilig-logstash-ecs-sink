using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Serilog.ElasticCommonSchema
{
    [DataContract]
    public class DeviceModel
    {
        /// <summary>
        /// Name of the device.
        /// type: keyword
        /// example: iPhone
        /// </summary>
        [DataMember]
        [JsonProperty("name")]
        public string Name { get; set; }       
    }
}