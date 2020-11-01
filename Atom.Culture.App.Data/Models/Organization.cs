using MongoDB.Bson;
namespace Atom.Culture.App.Data.Models
{
    public class Organization
    {
        public ObjectId Id { get; set; }
        public string OrgId { get; set; } 
        public string FullName { get; set; } 
        public string ShortName { get; set; } 
        public string Street { get; set; } 
        public string Metro { get; set; } 
    }
}
