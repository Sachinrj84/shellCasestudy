using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CaseStudy_webApi.EF_Core
{
    [Table("Incident")]
    public class Incident
    {
        [Key,Required]
        public int IncidentId { get; set; }
        public string IncidentType { get; set; } = string.Empty;
        public string IncidentDetails { get; set;} = string.Empty;
        public string Location {  get; set; } = string.Empty;
        public string Severity { get; set; }=string.Empty;
        public string Urgency { get; set; } = string.Empty;
        public string TimeStamp { get;set; } = string.Empty;
    }
}
