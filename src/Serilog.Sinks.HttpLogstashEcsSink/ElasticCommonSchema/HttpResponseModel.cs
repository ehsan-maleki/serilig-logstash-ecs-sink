using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Serilog.ElasticCommonSchema
{
    [DataContract]
    public class HttpResponseModel
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
        /// HTTP response status code.
        /// type: long
        /// example: 404
        /// </summary>
        [DataMember]
        [JsonProperty("status_code")]
        public long StatusCode { get; set; }       
    }
}