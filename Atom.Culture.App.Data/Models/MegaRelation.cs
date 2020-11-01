using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Text;

namespace Atom.Culture.App.Data.Models
{
    public class MegaRelation
    {
        public ObjectId Id { get; set; }
        public string EnrollId { get; set; }
        public string Status { get; set; }
        public string PupilId { get; set; }
        public string RecordCreateDate { get; set; }
        public string OrganizationId { get; set; }
        public string BlankId { get; set; }
        public string ServiceId { get; set; }
        public string CreditDate { get; set; }
        public string RemandDate { get; set; }
        public string TransferReason { get; set; }
        public string PrevCreditDate { get; set; }
        public string NextCreditDate { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
    }
}
