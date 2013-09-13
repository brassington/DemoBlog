using DemoBlog.Adapter.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DemoBlog.Adapter.Mock
{
    public class MockPostAdapter : IPostAdapter
    {

        public Models.ListPostsViewModel GetListPostsViewModel()
        {
            throw new NotImplementedException();
        }


        public Models.ListPostsViewModel CreateBlogPost(Models.ListPostsViewModel model)
        {
            throw new NotImplementedException();
        }
    }
}