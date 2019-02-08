using ArticleBazar.Model.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArticleBazar.Model.Authentication
{
    [Table("SystemUser", Schema = "Auth")]
    public class SystemUser:AuditableEntity<int,int,int>
    {
        [Required]
        [MaxLength(150)]
        public string FullName { get; set; }
        [Required]
        public int UserTypeId { get; set; }
       
        [MaxLength(50)]
        public string Email { get; set; }
        [MaxLength(50)]
        public string Phone { get; set; }

        [Required]
        [MaxLength(50)]
        public string Password { get; set; }

        [Required]
        public byte Status { get; set; }


        [ForeignKey("UserTypeId")]
        public virtual UserType UserType { get; set; }

    }
}
