using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WEB.Models;

    public class CommentContext : DbContext
    {
        public CommentContext (DbContextOptions<CommentContext> options)
            : base(options)
        {
        }

        public DbSet<WEB.Models.Comment> Comment { get; set; }
    }
