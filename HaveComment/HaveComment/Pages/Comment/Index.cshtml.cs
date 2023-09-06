using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using HaveComment.Data;
using HaveComment.Models;

namespace HaveComment.Pages.Comment
{
    public class IndexModel : PageModel
    {
        private readonly HaveComment.Data.HaveCommentContext _context;

        public IndexModel(HaveComment.Data.HaveCommentContext context)
        {
            _context = context;
        }

        public IList<Comments> Comments { get;set; }

        public async Task OnGetAsync()
        {
            Comments = await _context.Comment.ToListAsync();
        }
    }
}
