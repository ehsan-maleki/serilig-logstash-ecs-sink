using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Serilog.ElasticCommonSchema
{
    /// <summary>
    /// Fields related to HTTP activity. Use the url field set to store the url of the request.
    /// </summary>
    [DataContract]
    public class HttpModel
    {
        [DataMember]
        [JsonProperty("request")]
        public HttpRequestModel Request { get; set; }       
       
        [DataMember]
        [JsonProperty("response")]
        public HttpResponseModel Response { get; set; }       
       
        [DataMember]
        [JsonProperty("version")]
        public string Version { get; set; }       
    }
}