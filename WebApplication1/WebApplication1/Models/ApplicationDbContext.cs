﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }

        public ApplicationDbContext() : base("Githubexample")
        {

        }

    }
}