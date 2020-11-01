using MongoDB.Bson;

namespace Atom.Culture.App.Data.Models
{
    public class Book : Recomendation
    {
        public ObjectId Id { get; set; }
        public string DocId { get; set; }
        public string Author { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string Publisher { get; set; }
        public string Year { get; set; }
        public string Series { get; set; }
        public string Genre { get; set; }
        public string Knowledge { get; set; }
        public string MinAge { get; set; }
    }
}
