using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Serilog.ElasticCommonSchema
{
    /// <summary>
    /// Name of the image the container was built on.
    /// </summary>
    [DataContract]
    public class ContainerImageModel
    {
        /// <summary>
        /// Name of the image the container was built on.
        /// type: keyword
        /// </summary>
        [DataMember]
        [JsonProperty("name")]
        public string Name { get; set; }
        
        /// <summary>
        /// Container image tag.
        /// type: keyword
        /// </summary>
        [DataMember]
        [JsonProperty("tag")]
        public string Tag { get; set; }
    }
}