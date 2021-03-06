﻿using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Bson.Serialization.Attributes;

namespace CRM.DataAccess
{
    public class Users
    {
        [BsonId]
        public object internalId { get; set; }
        [BsonElement]
        public string firstName { get; set; }
        [BsonElement]
        public string lastName { get; set; }
        [BsonElement]
        public string userName { get; set; }
        [BsonElement]
        public string email { get; set; }
    }
}
