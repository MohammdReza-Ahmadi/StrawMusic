using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using HaveComment.Data;
using HaveComment.Models;

namespace HaveComment.Pages.Comment
{
    public class CreateModel : PageModel
    {
        private readonly HaveComment.Data.HaveCommentContext _context;

        public CreateModel(HaveComment.Data.HaveCommentContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Comments Comments { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Comment.Add(Comments);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
