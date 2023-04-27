﻿using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Charlotte.DateBase
{
    public class Episode
    {
        [BsonIgnoreIfNull]
        public string Title { get; set; }
        [BsonIgnoreIfNull]
        public string Description { get; set; }
    }
}