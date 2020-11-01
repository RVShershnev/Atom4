using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;

namespace Atom.Culture.App.Data.Models
{
    public class Person
    {
        [BsonId]
        public string Id { get; set; }
        public string Email { get; set; }
        public string BirthDate { get; set; }
        public List<Book> Books { get; set; }
        public List<Book> Recomendations { get; set; }
        public DateTime LastUpdate { get; set; }
    }
}
