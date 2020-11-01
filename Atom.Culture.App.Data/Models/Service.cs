using MongoDB.Bson;

namespace Atom.Culture.App.Data.Models
{
    public class Service : Recomendation
    {
        public ObjectId Id { get; set; }
        public string ServId { get; set; }
        public string FinancingType { get; set; }
        public string Classificator { get; set; }
        public string OrganizationId { get; set; }
        public string ScheduleType { get; set; }
        public string ServiceName { get; set; }
        public string CreateDate { get; set; }
        public string TrainingTime { get; set; }
        public string DurationUnit { get; set; }
    }
}
