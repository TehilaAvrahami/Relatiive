using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DBfiles
{
    [BsonIgnoreExtraElements]

    public class Contact
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]

        public string userId { get; set; } = null;
        public string IdUser { get; set; } = null;
        public string Mail { get; set; } = null;
        public string ContactPhone { get; set; } = null;
        public string image { get; set; } = null;

    }
}
