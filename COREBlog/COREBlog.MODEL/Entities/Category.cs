﻿using COREBlog.CORE.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace COREBlog.MODEL.Entities
{
    public class Category : CoreEntity
    {
        public string CategoryName { get; set; }
        public string Description { get; set; }

        public virtual List<Post> Posts { get; set; }
    }
}
