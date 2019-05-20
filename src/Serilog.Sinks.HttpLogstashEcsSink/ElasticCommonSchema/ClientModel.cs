using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Serilog.ElasticCommonSchema
{
    /// <summary>
    /// A client is defined as the initiator of a network connection for events regarding sessions, connections, or bidirectional flow records.
    /// 
    /// For TCP events, the client is the initiator of the TCP connection that sends the SYN packet(s).
    /// For other protocols, the client is generally the initiator or requestor in the network transaction.
    /// Some systems use the term "originator" to refer the client in TCP connections.
    /// The client fields describe details about the system acting as the client in the network event.
    /// Client fields are usually populated in conjunction with server fields.
    /// Client fields are generally not populated for packet-level events.
    ///
    /// Client / server representations can add semantic context to an exchange, which is helpful to visualize the data in certain situations.
    /// If your context falls in that category, you should still ensure that source and destination are filled appropriately.
    /// </summary>
    [DataContract]
    public class ClientModel
    {
        /// <summary>
        /// Some event client addresses are defined ambiguously.
        /// The event will sometimes list an IP, a domain or a unix socket.
        /// You should always store the raw address in the .address field.
        /// Then it should be duplicated to .ip or .domain, depending on which one it is.
        /// type: keyword
        /// </summary>
        [DataMember]
        [JsonProperty("address")]
        public string Address { get; set; }

        /// <summary>
        /// Bytes sent from the client to the server.
        /// type: long
        /// example: 184
        /// </summary>
        [DataMember]
        [JsonProperty("bytes")]
        public long Bytes { get; set; }
        
        /// <summary>
        /// Client domain.
        /// type: keyword
        /// </summary>
        [DataMember]
        [JsonProperty("domain")]
        public string Domain { get; set; }
        
        /// <summary>
        /// IP address of the client.
        /// Can be one or multiple IPv4 or IPv6 addresses.
        /// type: ip
        /// </summary>
        [DataMember]
        [JsonProperty("ip")]
        public string Ip { get; set; }
        
        /// <summary>
        /// MAC address of the client.
        /// type: keyword
        /// </summary>
        [DataMember]
        [JsonProperty("mac")]
        public string Mac { get; set; }
        
        /// <summary>
        /// Packets sent from the client to the server.
        /// type: long
        /// example: 12
        /// </summary>
        [DataMember]
        [JsonProperty("packets")]
        public long Packets { get; set; }
        
        /// <summary>
        /// Port of the client.
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