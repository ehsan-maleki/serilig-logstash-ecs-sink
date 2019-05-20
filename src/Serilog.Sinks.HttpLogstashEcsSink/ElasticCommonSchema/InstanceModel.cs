using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Serilog.ElasticCommonSchema
{
    [DataContract]
    public class InstanceModel
    {
        /// <summary>
        /// Instance ID of the host machine.
        /// type: keyword
        /// example: i-1234567890abcdef0
        /// </summary>
        [DataMember]
        [JsonProperty("id")]
        public string Id { get; set; }
        
        /// <summary>
        /// Instance name of the host machine.
        /// type: keyword
        /// </summary>
        [DataMember]
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}