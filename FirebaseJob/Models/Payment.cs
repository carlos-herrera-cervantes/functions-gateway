using System.ComponentModel.DataAnnotations;
using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;

namespace FirebaseJob.Models
{
    public class Payment : BaseEntity
    {
        [BsonElement("quantity")]
        [JsonProperty("quantity")]
        [Required]
        public decimal? Quantity { get; set; }

        [BsonElement("key")]
        [JsonProperty("key")]
        [Required]
        public string Key { get; set; }

        [BsonElement("description")]
        [JsonProperty("description")]
        public string Description { get; set; }
    }
}