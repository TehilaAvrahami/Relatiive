using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DBfiles
{
    public class User
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]

        public string FirstName { get; set; } = null;

        public string LastName { get; set; } = null;

        public string IdUser { get; set; } = null;

        public string Email { get; set; } = null;

        public string Phone { get; set; } = null;

        public string Password { get; set; } = null;
    }
}
