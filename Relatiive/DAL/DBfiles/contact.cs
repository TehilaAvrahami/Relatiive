using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DBfiles
{
   public class Contact
    {
        [BsonId]

        public string Mail { get; set; } = null;
        public string ContactPhone { get; set; } = null;
        public string image { get; set; } = null;
        public string userId { get; set; } = null;

    }
}
