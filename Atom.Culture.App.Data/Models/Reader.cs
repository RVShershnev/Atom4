using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Text;

namespace Atom.Culture.App.Data.Models
{
    public class Reader
    {
        public ObjectId Id { get; set; }
        public string ReaderId { get; set; }
        public string BirthDate { get; set; }
    }
}
