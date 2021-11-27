using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;

namespace FirebaseJob.Models
{
    public class Tax : BaseEntity
    {
        [BsonElement("percentage")]
        [JsonProperty("percentage")]
        public decimal Percentage { get; set; }

        [BsonElement("name")]
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}