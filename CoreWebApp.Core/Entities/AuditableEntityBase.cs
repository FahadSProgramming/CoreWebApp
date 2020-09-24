using System;
using System.Collections.Generic;
using System.Text;

namespace CoreWebApp.Core.Entities {
    public class AuditableEntityBase : EntityBase {
        public Guid CreatedBy { get; set; }
        public Guid ModifiedBy { get; set; }
    }
}
