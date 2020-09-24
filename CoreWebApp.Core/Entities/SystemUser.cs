using System;
using System.Collections.Generic;

namespace CoreWebApp.Core.Entities {
    public class SystemUser : EntityBase {
        public SystemUser() {
            Subordinates = new HashSet<SystemUser>();
            IncidentActivities = new HashSet<IncidentActivity>();
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Guid? PositionId { get; set; }
        public Designation Position { get; set; }
        public Guid? ManagerId { get; set; }
        public SystemUser Manager { get; set; }
        public ICollection<SystemUser> Subordinates { get; set; }
        public ICollection<Incident> Incidents { get; set; }
        public ICollection<IncidentActivity> IncidentActivities { get; set; }
    }
}
