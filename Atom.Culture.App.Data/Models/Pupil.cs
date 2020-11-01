using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Text;

namespace Atom.Culture.App.Data.Models
{
    public class Pupil
    {
        public ObjectId Id { get; set; }
        public string PupilId { get; set; }
        public string Age { get; set; }
        public string Sex { get; set; }
    }
}
