using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Day_3_Assignments.Models
{
    public class BlogPost
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public DateTime DatePosted { get; set; }
        public string Content { get; set; }

    }
}