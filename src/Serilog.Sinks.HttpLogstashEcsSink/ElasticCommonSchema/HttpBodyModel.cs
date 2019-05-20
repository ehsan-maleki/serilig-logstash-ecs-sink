using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Serilog.ElasticCommonSchema
{
    [DataContract]
    public class HttpBodyModel
    {
        /// <summary>
        /// Size in bytes of the request body.
        /// type: long
        /// example: 887
        /// </summary>
        [DataMember]
        [JsonProperty("bytes")]
        public long Bytes { get; set; }       
       
        /// <summary>
        /// The full HTTP request body.
        /// type: keyword
        /// example: Hello world
        /// </summary>
        [DataMember]
        [JsonProperty("content")]
        public string Content { get; set; }       
    }
}