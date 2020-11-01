using MongoDB.Bson;

namespace Atom.Culture.App.Data.Models
{
    public class Event : Recomendation
    {
        public ObjectId Id { get; set; }
        public string EvId { get; set; }
        public string Name { get; set; }
        public string Status { get; set; }
        public string InstitutionName { get; set; }
        public string InstitutionType { get; set; }
        public string Department { get; set; }
        public string FullCost { get; set; }
        public string EventType { get; set; }
        public string EventFocus { get; set; }
        public string IsAnnualAndCitywide { get; set; }
        public string FeastName { get; set; }
        public string StartDate { get; set; }
        public string StartTime { get; set; }
        public string EndDate { get; set; }
        public string EndTime { get; set; }
        public string ShortDescription { get; set; }
        public string IsOnline { get; set; }
        public string Location { get; set; }
        public string District { get; set; }
        public string Neighborhood { get; set; }
        public string AccessibleForDisable { get; set; }
        public string DisableType { get; set; }
        public string MaxAge { get; set; }
        public string AgeCategory { get; set; }
        public string TargetAudience { get; set; }
    }
}
