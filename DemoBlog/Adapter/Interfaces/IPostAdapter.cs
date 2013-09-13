using DemoBlog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoBlog.Adapter.Interfaces
{
    public interface IPostAdapter
    {
        ListPostsViewModel GetListPostsViewModel();
        ListPostsViewModel CreateBlogPost(ListPostsViewModel model);
    }
}
