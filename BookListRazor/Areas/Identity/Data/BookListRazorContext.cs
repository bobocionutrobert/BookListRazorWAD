﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookListRazor.Areas.Identity.Data;
using BookListRazor.Model;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BookListRazor.Data
{
    public class BookListRazorContext : IdentityDbContext<BookListRazorUser>
    {
        public BookListRazorContext(DbContextOptions<BookListRazorContext> options)
            : base(options)
        {
        }
        public DbSet<Book> Book { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }
    }
}
