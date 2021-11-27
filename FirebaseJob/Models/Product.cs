using System.ComponentModel.DataAnnotations;
using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;

namespace FirebaseJob.Models
{
    public class Product : BaseEntity
    {
        [BsonElement("name")]
        [JsonProperty("name")]
        [Required]
        public string Name { get; set; }

        [BsonElement("description")]
        [JsonProperty("description")]
        public string Description { get; set; }

        [BsonElement("quantity")]
        [JsonProperty("quantity")]
        [Required]
        public int? Quantity { get; set; }

        [BsonElement("priceUnit")]
        [JsonProperty("priceUnit")]
        [Required]
        public decimal? PriceUnit { get; set; }

        [BsonElement("price")]
        [JsonProperty("price")]
        [Required]
        public decimal? Price { get; set; }

        [BsonElement("measurementUnit")]
        [JsonProperty("measurementUnit")]
        [Required]
        public string MeasurementUnit { get; set; }

        [BsonElement("measurementUnitSat")]
        [JsonProperty("measurementUnitSat")]
        public string MeasurementUnitSat { get; set; }

        [BsonElement("taxes")]
        [JsonProperty("taxes")]
        public Tax[] Taxes { get; set; }
    }
}