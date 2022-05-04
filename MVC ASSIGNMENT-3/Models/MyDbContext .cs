﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MVC_Assignment3.Models
{
    public class MyDbContext : DbContext
    {
        public MyDbContext()
            : base("name=conn")
        {

        }
        public DbSet<User> Users { get; set; }

    }
}