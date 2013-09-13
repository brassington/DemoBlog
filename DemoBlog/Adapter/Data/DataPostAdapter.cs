using DemoBlog.Adapter.Interfaces;
using DemoBlog.Data;
using DemoBlog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DemoBlog.Adapter.Data
{
    public class DataPostAdapter : IPostAdapter
    {
        public Models.ListPostsViewModel GetListPostsViewModel()
        {
            ListPostsViewModel result = new ListPostsViewModel();
            BlogContext db = new BlogContext();

            result.Posts = db.Posts.ToList();

            return result;
        }
    }
}