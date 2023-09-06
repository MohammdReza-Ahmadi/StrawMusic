using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using blog;

namespace blog.Data
{
    public class blogContext : DbContext
    {
        public blogContext (DbContextOptions<blogContext> options)
            : base(options)
        {
        }

        public DbSet<blog.Comments> Comments { get; set; }
    }
}
