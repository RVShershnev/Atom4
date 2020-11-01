using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Text;

namespace Atom.Culture.App.Data.Models
{
    public class Instance
    {
        public ObjectId Id { get; set; }
        public string CopyId { get; set; }
        public string CatalogRecordId { get; set; }
        public string InventoryNumber { get; set; }
        public string BarCode { get; set; }
        public string Knowledge { get; set; }
        public string SiglaId { get; set; }
    }
}
