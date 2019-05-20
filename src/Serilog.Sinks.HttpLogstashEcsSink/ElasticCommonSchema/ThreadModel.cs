using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Serilog.ElasticCommonSchema
{
    [DataContract]
    public class ThreadModel
    {
        /// <summary>
        /// Thread ID.
        /// type: long
        /// example: 4242
        /// </summary>
        [DataMember]
        [JsonProperty("id")]
        public long Id { get; set; }       
    }
}