using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Site
    {
        public virtual long IdSite { get; set; }
        public virtual string Url { get; set; }
        public virtual List<User> Users { get; set; }
        public virtual Custumer Custumer { get; set; }
        public virtual Custumer IdCustumer{ get; set; }



    }
}
