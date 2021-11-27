using System.ComponentModel.DataAnnotations;
using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;

namespace FirebaseJob.Models
{
    public class Client : BaseEntity
    {
        [BsonElement("email")]
        [JsonProperty("email")]
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
    }
}