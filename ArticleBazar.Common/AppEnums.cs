using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArticleBazar.Common
{
    public class AppEnums
    {

        public enum ActiveStatus
        {
            Active=1,
            InActive=2,
            Pending=3
        }


        public enum Error
        {
            Already = -1,
            SystemError = -2,
        }
    }
}
