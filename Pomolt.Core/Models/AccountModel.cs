﻿using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Promolt.Core.Models
{
    public class AccountModel
    {

        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }
        public decimal Cash { get; set; }
        [BsonRepresentation(BsonType.ObjectId)]
        public string Owner { get; set; } = null!;
    }
}
