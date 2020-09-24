using System;
using System.Collections.Generic;

namespace CoreWebApp.Core.Entities {
    public class Contact : EntityBase {
        public Contact() {
            Projects = new HashSet<Project>();
            Incidents = new HashSet<Incident>();
            IncidentActivities = new HashSet<IncidentActivity>();
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public Guid CustomerId { get; set; }
        public Customer Customer { get; set; }
        public ICollection<Project> Projects { get; set; }
        public ICollection<Incident> Incidents { get; set; }
        public ICollection<IncidentActivity> IncidentActivities { get; set; }
    }
}
