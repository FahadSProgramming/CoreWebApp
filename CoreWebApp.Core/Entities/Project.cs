using System;
using System.Collections;
using System.Collections.Generic;

namespace CoreWebApp.Core.Entities {
    public class Project : EntityBase {
        public Project() {
            Incidents = new HashSet<Incident>();
        }
        public string Title { get; set; }
        public string Code { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public Guid CustomerId { get; set; }
        public Customer Customer { get; set; }
        public Guid? ContactId { get; set; }
        public Contact Contact { get; set; }
        public ICollection<Incident> Incidents { get; set; }
    }
}
