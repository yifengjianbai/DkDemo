using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DkDemo
{
    public class WRequest
    {
        public string Name { get; set; }
        public string Pwd { get; set; }
    }

    public enum UserType
    {
        ComUser = 0,
        VipUser = 1,
        SvipUser = 2,
        SSvipUser = 3,
    }
}
