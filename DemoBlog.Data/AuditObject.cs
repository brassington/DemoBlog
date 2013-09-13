using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoBlog.Data
{
    public abstract class AuditObject
    {
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdate { get; set; }
    }
}
