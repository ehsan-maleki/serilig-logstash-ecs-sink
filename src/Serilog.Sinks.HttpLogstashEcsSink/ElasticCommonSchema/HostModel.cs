using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Serilog.ElasticCommonSchema
{
    /// <summary>
    /// A host is defined as a general computing instance.
    /// ECS host.* fields should be populated with details about the host on which the event happened,
    /// or from which the measurement was taken. Host types include hardware, virtual machines,
    /// Docker containers, and Kubernetes nodes.
    /// </summary>
    [DataContract]
    public class HostModel
    {
        /// <summary>
        /// Operating system architecture.
        /// type: keyword
        /// example: x86_64
        /// </summary>
        [DataMember]
        [JsonProperty("architecture")]
        public string Architecture { get; set; }       
       
        /// <summary>
        /// Hostname of the host.
        /// It normally contains what the hostname command returns on the host machine.
        /// type: keyword
        /// </summary>
        [DataMember]
        [JsonProperty("hostname")]
        public string HostName { get; set; }       
       
        /// <summary>
        /// Unique host id.
        /// As hostname is not always unique, use values that are meaningful in your environment.
        /// Example: The current usage of beat.name.
        /// type: keyword
        /// </summary>
        [DataMember]
        [JsonProperty("id")]
        public string Id { get; set; }       
       
        /// <summary>
        /// Host ip address.
        /// type: ip
        /// </summary>
        [DataMember]
        [JsonProperty("ip")]
        public string Ip { get; set; }       
       
        /// <summary>
        /// Host mac address.
        /// type: keyword
        /// </summary>
        [DataMember]
        [JsonProperty("mac")]
        public string Mac { get; set; }       
       
        /// <summary>
        /// Name of the host.
        /// It can contain what hostname returns on Unix systems, the fully qualified domain name,
        /// or a name specified by the user. The sender decides which value to use.
        /// type: keyword
        /// </summary>
        [DataMember]
        [JsonProperty("name")]
        public string Name { get; set; }       
       
        /// <summary>
        /// Type of host.
        /// For Cloud providers this can be the machine type like t2.medium.
        /// If vm, this could be the container, for example, or other information meaningful in your environment.
        /// type: keyword
        /// </summary>
        [DataMember]
        [JsonProperty("type")]
        public string Type { get; set; }       
       
        /// <summary>
        /// Fields describing a location.
        /// </summary>
        [DataMember]
        [JsonProperty("geo")]
        public GeoModel Geo { get; set; }       
       
        /// <summary>
        /// OS fields contain information about the operating system.
        /// </summary>
        [DataMember]
        [JsonProperty("os")]
        public OperatingSystemModel Os { get; set; }       
       
        /// <summary>
        /// Fields to describe the user relevant to the event.
        /// </summary>
        [DataMember]
        [JsonProperty("user")]
        public string User { get; set; } 
    }
}