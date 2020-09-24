using System;
using System.Collections.Generic;
using System.Text;

namespace CoreWebApp.Core.Entities {
    public class Incident : EntityBase {
        public Incident() {
            IncidentActivities = new HashSet<IncidentActivity>();
        }
        public string Title { get; set; }
        public string Description { get; set; }
        public int Severity { get; set; }
        public int Priority { get; set; }
        public Guid? SystemUserId { get; set; }
        public SystemUser SystemUser { get; set; }
        public Guid CategoryId { get; set; }
        public Category Category { get; set; }
        public Guid ProjectId { get; set; }
        public Project Project { get; set; }
        public Guid ContactId { get; set; }
        public Contact Contact { get; set; }
        public Guid CustomerId { get; set; }
        public Customer Customer { get; set; }
        public ICollection<IncidentActivity> IncidentActivities { get; set; }
    }
}
