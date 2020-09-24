using System;
using System.Collections.Generic;
using System.Text;

namespace CoreWebApp.Core.Entities {
    public class Customer : EntityBase {
        public Customer() {
            Incidents = new HashSet<Incident>();
            Projects = new HashSet<Project>();
            Contacts = new HashSet<Contact>();
        }
        public string Name { get; set; }
        public string Website { get; set; }
        public ICollection<Contact> Contacts { get; set; }
        public ICollection<Project> Projects { get; set; }
        public ICollection<Incident> Incidents { get; set; }
    }
}
