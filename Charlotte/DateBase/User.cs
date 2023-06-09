﻿using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Charlotte.DateBase
{
    [BsonIgnoreExtraElements]
    public class User
    {
        [BsonIgnoreIfNull]
        public int IdUser { get; set; }
        [BsonIgnoreIfNull]
        public string Login { get; set; }
        [BsonIgnoreIfNull]
        public string Password { get; set; }
        [BsonIgnoreIfNull]
        public string Email { get; set; }
        [BsonIgnoreIfNull]
        public byte[] Photo { get; set; }
        [BsonIgnore]
        public User currentUser;
    }
}
