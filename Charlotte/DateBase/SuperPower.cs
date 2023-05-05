using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Charlotte.DateBase
{
    [BsonIgnoreExtraElements]
    public class SuperPower
    {
        [BsonIgnoreIfNull]
        public string IdSuperPower { get; set; }
        [BsonIgnoreIfNull]
        public string Name { get; set; }
        [BsonIgnoreIfNull]
        public string Description { get; set; }
        [BsonIgnoreIfNull]
        public byte[] MainImage { get; set; }

        [BsonIgnoreIfNull]
        public string idCharacter { get; set; }
    }
}
