using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoBlog.Data
{
    public class Post : AuditObject
    {
        public int PostId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
