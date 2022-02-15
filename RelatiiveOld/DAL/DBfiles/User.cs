using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace ClassLibrary1.DBfiles
{
    class User
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]

        public string FirstName { get; set; } = null;

        public string LastName { get; set; } = null;

        public string IdUser { get; set; }

        public string Phone { get; set; } = null;

        public string EmergencyPhone { get; set; } = null;
    }
}
