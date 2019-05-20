using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Serilog.ElasticCommonSchema
{
    [DataContract]
    public class HttpRequestModel
    {
        [DataMember]
        [JsonProperty("body")]
        public HttpBodyModel Body { get; set; }       

        /// <summary>
        /// Total size in bytes of the request (body and headers).
        /// type: long
        /// example: 1437
        /// </summary>
        [DataMember]
        [JsonProperty("bytes")]
        public long Bytes { get; set; }       
       
        /// <summary>
        /// HTTP request method.
        /// The field value must be normalized to lowercase for querying. See the documentation section "Implementing ECS".
        /// type: keyword
        /// example: get, post, put
        /// </summary>
        [DataMember]
        [JsonProperty("method")]
        public string Method { get; set; }       

        /// <summary>
        /// Referrer for this HTTP request.
        /// type: keyword
        /// example: https://blog.example.com/
        /// </summary>
        [DataMember]
        [JsonProperty("referrer")]
        public string Referrer { get; set; }
    }
}