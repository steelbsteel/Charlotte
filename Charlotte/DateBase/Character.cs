using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Charlotte.DateBase
{
    public class Character
    {
        [BsonIgnoreIfNull]
        public int IdCharacter { get; set; }
        [BsonIgnoreIfNull]
        public string Name { get; set; }
        [BsonIgnoreIfNull]
        public string Description { get; set; }
        [BsonIgnoreIfNull]
        public byte[] MainImage { get; set; }
        [BsonIgnoreIfNull]
        public int Age { get; set; }
        [BsonIgnoreIfNull]
        public string Status { get; set; }
        [BsonIgnoreIfNull]
        public int CommentarysCount { get; set; }
    }
}
