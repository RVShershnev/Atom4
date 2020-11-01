using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Text;

namespace Atom.Culture.App.Data.Models
{
    public class Request
    {
        public ObjectId Id { get; set; }
        public string ApplizationId { get; set; }
        public string ApplicationStatus { get; set; }
        public string CreationDate { get; set; }
        public string EntranceExamAssessment { get; set; }
        public string ExamIsPass { get; set; }
        public string EnrollmentAllowed { get; set; }
        public string EnrollmentNotAllowed { get; set; }
        public string RejectReason { get; set; }
        public string ServiceId { get; set; }
    }
}
