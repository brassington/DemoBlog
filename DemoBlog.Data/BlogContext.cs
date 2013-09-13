using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoBlog.Data
{
    public class BlogContext : DbContext
    {
        public DbSet<Post> Posts { get; set; }
    }
}
