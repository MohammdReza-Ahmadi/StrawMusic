using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using HaveComment.Models;

namespace HaveComment.Data
{
    public class HaveCommentContext : DbContext
    {
        public HaveCommentContext (DbContextOptions<HaveCommentContext> options)
            : base(options)
        {
        }

        public DbSet<HaveComment.Models.Comments> Comment { get; set; }
    }
}
