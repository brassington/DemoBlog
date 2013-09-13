using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.Migrations;

namespace DemoBlog.Data.Migrations
{
    public class Seeder
    {
        public static void Seed(BlogContext db,
            bool seedPosts = true)
        {
            if (seedPosts) CreatePosts(db);
        }

        private static void CreatePosts(BlogContext db)
        {
            db.Posts.AddOrUpdate(p => p.Title,
                new Post() { Title = "This is the test post", Description = "Description of the test post", DateCreated = DateTime.Now.AddDays(-20), DateUpdate = DateTime.Now.AddDays(-19) },
                new Post() { Title = "This is the test post 2", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit fusce vel sapien elit in malesuada semper mi, id sollicitudin urna fermentum ut fusce varius nisl ac ipsum gravida vel pretium tellus.", DateCreated = DateTime.Now.AddDays(-20), DateUpdate = DateTime.Now.AddDays(-19) },
                new Post() { Title = "This is the test post 3", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit fusce vel sapien elit in malesuada semper mi, id sollicitudin urna fermentum ut fusce varius nisl ac ipsum gravida vel pretium tellus.", DateCreated = DateTime.Now.AddDays(-20), DateUpdate = DateTime.Now.AddDays(-19) },
                new Post() { Title = "This is the test post 4", Description = "Blah, blah, blah, blah", DateCreated = DateTime.Now.AddDays(-20), DateUpdate = DateTime.Now.AddDays(-19) },
                new Post() { Title = "This is the test post 5", Description = "Lorem ipsum.", DateCreated = DateTime.Now.AddDays(-20), DateUpdate = DateTime.Now.AddDays(-19) },
                new Post() { Title = "This is the test post 6", Description = "Dolor sit amet, consectetur adipiscing elit fusce", DateCreated = DateTime.Now.AddDays(-20), DateUpdate = DateTime.Now.AddDays(-19) }
                );

        }
    }
}
