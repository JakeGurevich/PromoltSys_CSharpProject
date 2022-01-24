using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Promolt.Core.Models
{
    public class DonationModel
    {

        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }
        public string ProductName { get; set; } = null!;
        public int Qty { get; set; }
        public decimal? Price { get; set; }
        
        [BsonRepresentation(BsonType.ObjectId)]
        public string DonatedBy { get; set; } = null!;
        public DateTime CreatedAt { get; set; }
    }
}
