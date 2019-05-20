using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Serilog.ElasticCommonSchema
{
    /// <summary>
    /// The group fields are meant to represent groups that are relevant to the event.
    /// </summary>
    [DataContract]
    public class GroupModel
    {
        /// <summary>
        /// Unique identifier for the group on the system/platform.
        /// type: keyword
        /// </summary>
        [DataMember]
        [JsonProperty("id")]
        public string Id { get; set; }       
       
        /// <summary>
        /// Name of the group.
        /// type: keyword
        /// </summary>
        [DataMember]
        [JsonProperty("name")]
        public string Name { get; set; }       
       
    }
}