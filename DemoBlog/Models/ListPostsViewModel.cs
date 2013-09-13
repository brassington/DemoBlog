using DemoBlog.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DemoBlog.Models
{
    public class ListPostsViewModel
    {
        public Post Post { get; set; }
        public List<Post> Posts { get; set; }
    }
}