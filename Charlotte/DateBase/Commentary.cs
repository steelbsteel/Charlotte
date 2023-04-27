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
        public string Date { get; set; }
        [BsonIgnoreIfNull]
        public string Description { get; set; }
        [BsonIgnoreIfNull]
        public int idUser { get; set; }
        [BsonIgnoreIfNull]
        public int idPage { get; set; }
    }
}
