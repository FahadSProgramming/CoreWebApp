using System;

namespace CoreWebApp.Core.Entities {
    public class IncidentActivity : EntityBase {
        public string Title { get; set; }
        public string Body { get; set; }
        public Guid? ContactId { get; set; }
        public Contact Contact { get; set; }
        public Guid? SystemUserId { get; set; }
        public SystemUser SystemUser { get; set; }
        public Guid IncidentId { get; set; }
        public Incident Incident { get; set; }
    }
}
