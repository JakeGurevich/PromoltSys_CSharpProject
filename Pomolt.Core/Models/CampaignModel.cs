using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Promolt.Core.Models
{
    public class CampaignModel
    {

        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }
        public string Title { get; set; } = null!;
        public string Hashtag { get; set; } = null!;
        public string Url { get; set; } = null!;
        [BsonRepresentation(BsonType.ObjectId)]
        public string CreatedBy { get; set; } = null!;
        public DateTimeOffset CreatedAt { get; set; }
    }
}
