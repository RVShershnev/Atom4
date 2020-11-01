using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Text;

namespace Atom.Culture.App.Data.Models
{
    public class Classificator
    {
        public ObjectId Id { get; set; }
        public string ClassificatorId { get; set; }
        public string ParentClassificatorId { get; set; }
        public string Name { get; set; }
    }
}
