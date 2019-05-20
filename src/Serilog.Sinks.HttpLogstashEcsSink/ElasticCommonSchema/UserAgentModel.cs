using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Serilog.ElasticCommonSchema
{
    [DataContract]
    public class UserAgentModel
    {
        [DataMember]
        [JsonProperty("device")]
        public DeviceModel Device { get; set; }       

        /// <summary>
        /// Name of the user agent.
        /// type: keyword
        /// example: Safari
        /// </summary>
        [DataMember]
        [JsonProperty("name")]
        public string Name { get; set; }       

        /// <summary>
        /// Unparsed version of the user_agent.
        /// type: keyword
        /// example: Mozilla/5.0 (iPhone; CPU iPhone OS 12_1 like Mac OS X) AppleWebKit/605.1.15 (KHTML, like Gecko) Version/12.0 Mobile/15E148 Safari/604.1
        /// </summary>
        [DataMember]
        [JsonProperty("original")]
        public string Original { get; set; }       

        /// <summary>
        /// Version of the user agent.
        /// type: keyword
        /// example: 12.0
        /// </summary>
        [DataMember]
        [JsonProperty("version")]
        public string Version { get; set; }       
    }
}