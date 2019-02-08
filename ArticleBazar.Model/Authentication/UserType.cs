using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArticleBazar.Model.Authentication
{
    [Table("UserType", Schema ="Auth")]
   public class UserType:Entity<int>
    {
        public string TypeName { get; set; }

        public virtual ICollection<SystemUser> SystemUsers { get; set; }

    }
}
