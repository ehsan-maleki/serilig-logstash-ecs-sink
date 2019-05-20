using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Serilog.ElasticCommonSchema
{
    /// <summary>
    /// The organization fields enrich data with information about the company or entity the data is associated with.
    /// These fields help you arrange or filter data stored in an index by one or multiple organizations.
    /// </summary>
    [DataContract]
    public class OrganizationModel
    {
        /// <summary>
        /// Unique identifier for the organization.
        /// type: keyword
        /// </summary>
        [DataMember]
        [JsonProperty("id")]
        public string Id { get; set; }       
       
        /// <summary>
        /// Organization name.
        /// type: keyword
        /// </summary>
        [DataMember]
        [JsonProperty("name")]
        public string Name { get; set; }       
       
    }
}