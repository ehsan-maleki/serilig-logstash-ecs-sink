using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Serilog.ElasticCommonSchema
{
    [DataContract]
    public class BaseModel
    {
        [DataMember]
        [JsonProperty("@timestamp")]
        public DateTime Timestamp { get; set; }

        [DataMember]
        [JsonProperty("labels")]
        public List<KeyValuePair<string, string>> Type { get; set; }

        [DataMember]
        [JsonProperty("tags")]
        public List<string> Tags { get; set; }

        [DataMember]
        [JsonProperty("agent")]
        public AgentModel Agent { get; set; }

        [DataMember]
        [JsonProperty("client")]
        public ClientModel Client { get; set; }

        /// <summary>
        /// ECS version this event conforms to. ecs.version is a required field and must exist in all events.
        /// When querying across multiple indices — which may conform to slightly different ECS versions —
        /// this field lets integrations adjust to the schema version of the events.
        /// type: keyword
        /// example: 1.0.0
        /// </summary>
        [DataMember]
        [JsonProperty("version")]
        public string Version { get; set; }
    }
}