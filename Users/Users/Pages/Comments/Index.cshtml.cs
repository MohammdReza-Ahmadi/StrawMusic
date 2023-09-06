using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Users;
using Users.Data;

namespace Users.Pages.Comments
{
    public class IndexModel : PageModel
    {
        private readonly Users.Data.UsersContext _context;

        public IndexModel(Users.Data.UsersContext context)
        {
            _context = context;
        }

        public IList<Comment> Comment { get; set; }
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        public SelectList CommentTittel { get; set; }
        [BindProperty(SupportsGet = true)]
        public int Status { get; set; }
        public async Task OnGetAsync()
        {
            IQueryable<string> genreQuery = from m in _context.Comment
                                            orderby m.Tittel
                                            select m.Tittel;
            var comments = from m in _context.Comment
                           select m;
            if (!string.IsNullOrEmpty(SearchString))
            {
                comments = comments.Where(s => s.Text.Contains(SearchString));
            }
            if (Status != 0)
            {
                comments = comments.Where(x => x.Status == Status);
            }
            CommentTittel = new SelectList(await genreQuery.Distinct().ToListAsync());
            Comment = await _context.Comment.ToListAsync();
        }
    }
}
