using System.ComponentModel.DataAnnotations;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;

namespace FirebaseJob.Models
{
    public class CustomerPurchase : BaseEntity
    {
        #region snippet_Properties

        [BsonElement("folio")]
        [JsonProperty("folio")]
        [Required]
        public string Folio { get; set; }

        [BsonElement("vat")]
        [JsonProperty("vat")]
        [Required]
        public decimal? Vat { get; set; }

        [BsonElement("subtotal")]
        [JsonProperty("subtotal")]
        [Required]
        public decimal? Subtotal { get; set; }

        [BsonElement("total")]
        [JsonProperty("total")]
        [Required]
        public decimal? Total { get; set; }

        [BsonElement("totalLetters")]
        [JsonProperty("totalLetters")]
        [Required]
        public string TotalLetters { get; set; }

        [BsonElement("userId")]
        [JsonProperty("userId")]
        [Required]
        [BsonRepresentation(BsonType.ObjectId)]
        public string UserId { get; set; }

        [BsonElement("products")]
        [JsonProperty("products")]
        [Required]
        [MinLength(1)]
        public Product[] Products { get; set; }

        [BsonElement("payments")]
        [JsonProperty("payments")]
        [Required]
        [MinLength(1)]
        public Payment[] Payments { get; set; }

        [BsonElement("client")]
        [JsonProperty("client")]
        [Required]
        public Client Client { get; set; }

        #endregion

        #region snippet_References

        [BsonElement("station")]
        [JsonProperty("station")]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Station { get; set; }

        #endregion
    }
}