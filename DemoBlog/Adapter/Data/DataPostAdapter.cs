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



        public ListPostsViewModel CreateBlogPost(ListPostsViewModel model)
        {
            using (BlogContext db = new BlogContext())
            {

                Post post = model.Post;

                post.Title = "New Blog Post Title";
                post.Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit fusce vel sapien elit in malesuada semper mi, id sollicitudin urna fermentum."

                db.Posts.Add(post);
                db.SaveChanges();

            }
            return model;
        }
    }
}