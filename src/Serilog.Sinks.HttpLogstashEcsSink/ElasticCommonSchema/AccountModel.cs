using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Serilog.ElasticCommonSchema
{
    [DataContract]
    public class AccountModel
    {
        /// <summary>
        /// The cloud account or organization id used to identify different entities in a multi-tenant environment.
        /// Examples: AWS account id, Google Cloud ORG Id, or other unique identifier.
        /// type: keyword
        /// example: 666777888999
        /// </summary>
        [DataMember]
        [JsonProperty("id")]
        public string Id { get; set; }
    }
}