using System.Collections.Generic;

namespace CoreWebApp.Core.Entities {
    public class Designation : EntityBase {
        public string Name { get; set; }
        public ICollection<SystemUser> SystemUsers { get; set; }
    }
}
