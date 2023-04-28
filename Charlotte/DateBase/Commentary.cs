using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Charlotte.DateBase
{
    public class Commentary
    {
        [BsonIgnoreIfNull]
        public int IdCommentary { get; set; }
        [BsonIgnoreIfNull]
        public string Date { get; set; }
        [BsonIgnoreIfNull]
        public string Description { get; set; }
        [BsonIgnoreIfNull]
        public int idUser { get; set; }
        [BsonIgnoreIfNull]
        public int idCharacter { get; set; }
        [BsonIgnoreIfNull]
        public int idSuperPower { get; set; }
        [BsonIgnoreIfNull]
        public int idEpisode { get; set; }

    }
}
