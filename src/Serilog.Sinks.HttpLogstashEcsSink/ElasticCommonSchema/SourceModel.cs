using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Serilog.ElasticCommonSchema
{
    /// <summary>
    /// Source fields describe details about the source of a packet/event.
    /// Source fields are usually populated in conjunction with destination fields.
    /// </summary>
    [DataContract]
    public class SourceModel
    {
        /// <summary>
        /// Some event source addresses are defined ambiguously.
        /// The event will sometimes list an IP, a domain or a unix socket.
        /// You should always store the raw address in the .address field.
        /// Then it should be duplicated to .ip or .domain, depending on which one it is.
        /// type: keyword
        /// </summary>
        [DataMember]
        [JsonProperty("address")]
        public string Address { get; set; }       

        /// <summary>
        /// Bytes sent from the source to the destination.
        /// type: long
        /// example: 184
        /// </summary>
        [DataMember]
        [JsonProperty("bytes")]
        public long Bytes { get; set; }       

        /// <summary>
        /// Source domain.
        /// type: keyword
        /// </summary>
        [DataMember]
        [JsonProperty("domain")]
        public string Domain { get; set; }       

        /// <summary>
        /// IP address of the source.
        /// Can be one or multiple IPv4 or IPv6 addresses.
        /// type: ip
        /// </summary>
        [DataMember]
        [JsonProperty("ip")]
        public string Ip { get; set; }       

        /// <summary>
        /// MAC address of the source.
        /// type: keyword
        /// </summary>
        [DataMember]
        [JsonProperty("mac")]
        public string Mac { get; set; }       

        /// <summary>
        /// Packets sent from the source to the destination.
        /// type: long
        /// example: 12
        /// </summary>
        [DataMember]
        [JsonProperty("packets")]
        public long Packets { get; set; }       

        /// <summary>
        /// Port of the source.
        /// type: long
        /// </summary>
        [DataMember]
        [JsonProperty("port")]
        public long Port { get; set; }       

        /// <summary>
        /// Fields describing a location.
        /// </summary>
        [DataMember]
        [JsonProperty("geo")]
        public GeoModel Geo { get; set; }

        /// <summary>
        /// Fields to describe the user relevant to the event.
        /// </summary>
        [DataMember]
        [JsonProperty("user")]
        public UserModel User { get; set; }

    }
}