using System;
using System.Collections.Generic;
using System.Text;

namespace CoreWebApp.Core.Entities {
    public class Category : EntityBase{
        public string Name { get; set; }
        public ICollection<Incident> Incidents { get; set; }
    }
}
