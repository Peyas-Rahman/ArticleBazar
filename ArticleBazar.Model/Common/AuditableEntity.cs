using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArticleBazar.Model.Common
{
   public class AuditableEntity<T,TEntryBy,TUpdatedBy>:Entity<T>
    {

        public TEntryBy EntryBy { get; set; }
        public TUpdatedBy UpdatedBy { get; set; }
        public DateTime EntryDate { get; set; }
        public DateTime UpdatedDate { get; set; }

    }
}
