using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Serilog.ElasticCommonSchema
{
    /// <summary>
    /// Fields related to the cloud or infrastructure the events are coming from.
    /// </summary>
    [DataContract]
    public class CloudModel
    {
        /// <summary>
        /// The cloud account or organization id used to identify different entities in a multi-tenant environment.
        /// </summary>
        [DataMember]
        [JsonProperty("account")]
        public AccountModel Account { get; set; }

        /// <summary>
        /// Availability zone in which this host is running.
        /// type: keyword
        /// example: us-east-1c
        /// </summary>
        [DataMember]
        [JsonProperty("availability_zone")]
        public string AvailabilityZone { get; set; }
      
        /// <summary>
        /// Name of the cloud provider. Example values are aws, azure, gcp, or digitalocean.
        /// type: keyword
        /// example: aws
        /// </summary>
        [DataMember]
        [JsonProperty("provider")]
        public string Provider { get; set; }
      
        /// <summary>
        /// Region in which this host is running.
        /// type: keyword
        /// example: us-east-1
        /// </summary>
        [DataMember]
        [JsonProperty("region")]
        public string Region { get; set; }
    }
}