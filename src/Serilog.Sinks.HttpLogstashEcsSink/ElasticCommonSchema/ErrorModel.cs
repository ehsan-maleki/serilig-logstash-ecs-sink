using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Serilog.ElasticCommonSchema
{
    /// <summary>
    /// These fields can represent errors of any kind.
    /// Use them for errors that happen while fetching events or in cases where the event itself contains an error.
    /// </summary>
    [DataContract]
    public class ErrorModel
    {
        /// <summary>
        /// Error code describing the error.
        /// type: keyword
        /// </summary>
        [DataMember]
        [JsonProperty("code")]
        public string Code { get; set; }

        /// <summary>
        /// Unique identifier for the error.
        /// type: keyword
        /// </summary>
        [DataMember]
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// Error message.
        /// type: text
        /// </summary>
        [DataMember]
        [JsonProperty("message")]
        public string Message { get; set; }
    }
}