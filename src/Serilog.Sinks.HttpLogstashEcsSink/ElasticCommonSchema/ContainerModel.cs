using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Serilog.ElasticCommonSchema
{
    /// <summary>
    /// Container fields are used for meta information about the specific container that is the source of information.
    /// These fields help correlate data based containers from any runtime.
    /// </summary>
    [DataContract]
    public class ContainerModel
    {
        /// <summary>
        /// Unique container id.
        /// type: keyword
        /// </summary>
        [DataMember]
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// Name of the image the container was built on.
        /// </summary>
        [DataMember]
        [JsonProperty("image")]
        public string Image { get; set; }

        /// <summary>
        /// Image labels.
        /// </summary>
        [DataMember]
        [JsonProperty("labels")]
        public List<KeyValuePair<string, string>> Type { get; set; }

        /// <summary>
        /// Container name.
        /// type: keyword
        /// </summary>
        [DataMember]
        [JsonProperty("name")]
        public string Name { get; set; }
        
        /// <summary>
        /// Runtime managing this container.
        /// type: keyword
        /// example: docker
        /// </summary>
        [DataMember]
        [JsonProperty("runtime")]
        public string Runtime { get; set; }       
    }
}