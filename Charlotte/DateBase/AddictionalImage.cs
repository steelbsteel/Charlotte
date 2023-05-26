using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Charlotte.DateBase
{
    [BsonIgnoreExtraElements]
    public class AddictionalImage
    {
        [BsonIgnoreIfNull]
        public byte[] Photo { get; set; }

        [BsonIgnoreIfNull]
        public string idPage { get; set; }
    }
}
