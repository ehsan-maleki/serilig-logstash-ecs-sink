using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Serilog.ElasticCommonSchema
{
    [DataContract]
    public class MachineModel
    {
        /// <summary>
        /// Machine type of the host machine.
        /// type: keyword
        /// example: t2.medium
        /// </summary>
        [DataMember]
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}