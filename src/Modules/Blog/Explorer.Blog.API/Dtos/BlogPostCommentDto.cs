﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Explorer.Blog.API.Dtos
{
    public class BlogPostCommentDto
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public int UserId { get; set; }
        public int BlogId { get; set; }
        public DateTime CreationTime { get; set; }
        public DateTime LastUpdatedTime { get; set;}
    }
}
