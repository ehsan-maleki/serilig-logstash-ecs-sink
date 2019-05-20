using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Serilog.ElasticCommonSchema
{
    /// <summary>
    /// Geo fields can carry data about a specific location related to an event.
    /// This geolocation information can be derived from techniques such as Geo IP, or be user-supplied.
    /// </summary>
    [DataContract]
    public class GeoModel
    {
        /// <summary>
        /// City name.
        /// type: keyword
        /// example: Montreal
        /// </summary>
        [DataMember]
        [JsonProperty("city_name")]
        public string CityName { get; set; }       

        /// <summary>
        /// Name of the continent.
        /// type: keyword
        /// example: North America
        /// </summary>
        [DataMember]
        [JsonProperty("continent_name")]
        public string ContinentName { get; set; }       

        /// <summary>
        /// Country ISO code.
        /// type: keyword
        /// example: CA
        /// </summary>
        [DataMember]
        [JsonProperty("country_iso_code")]
        public string CountryIsoCode { get; set; }       

        /// <summary>
        /// Country name.
        /// type: keyword
        /// example: Canada
        /// </summary>
        [DataMember]
        [JsonProperty("country_name")]
        public string CountryName { get; set; }       

        /// <summary>
        /// Longitude and latitude.
        /// type: geo_point
        /// example: { "lon": -73.614830, "lat": 45.505918 }
        /// </summary>
        [DataMember]
        [JsonProperty("location")]
        public GeoLocationModel Location { get; set; }       

        /// <summary>
        /// User-defined description of a location, at the level of granularity they care about.
        /// Could be the name of their data centers, the floor number, if this describes a local physical entity, city names.
        /// Not typically used in automated geolocation.
        /// type: keyword
        /// example: boston-dc
        /// </summary>
        [DataMember]
        [JsonProperty("name")]
        public string Name { get; set; }       

        /// <summary>
        /// Region ISO code.
        /// type: keyword
        /// example: CA-QC
        /// </summary>
        [DataMember]
        [JsonProperty("region_iso_code")]
        public string RegionIsoCode { get; set; }

        /// <summary>
        /// Region name.
        /// type: keyword
        /// example: Quebec
        /// </summary>
        [DataMember]
        [JsonProperty("region_name")]
        public string RegionName { get; set; }
    }
}