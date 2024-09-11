using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Day_3_Assignments.Models
{
    public class MockBlogRepository
    {
        public List<BlogPost> GetBlogPosts()
        {
            // Mock data
            var posts = new List<BlogPost>
        {
            new BlogPost
            {
                Id = 1,
                Title = "First Blog Post",
                Author = "John Doe",
                DatePosted = DateTime.Now.AddDays(-2),
                Content = "This is the content of the first blog post. Lorem ipsum..."
            },
            new BlogPost
            {
                Id = 2,
                Title = "Second Blog Post",
                Author = "Jane Smith",
                DatePosted = DateTime.Now.AddDays(-1),
                Content = "This is the content of the second blog post. Lorem ipsum..."
            }
            // Add more blog posts as needed
        };

            return posts;
        }

    }
}