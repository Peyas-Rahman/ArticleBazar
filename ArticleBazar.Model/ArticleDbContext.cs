using ArticleBazar.Model.Authentication;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArticleBazar.Model
{
   public class ArticleDbContext:DbContext
    {

        public ArticleDbContext():base("ArticleBazarConnection")
        {

        }
  

        public DbSet<UserType> UserType { get; set; }
        public DbSet<SystemUser> SystemUser { get; set; }

    }
}
