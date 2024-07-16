using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using filmDunyasi.Data;
using filmDunyasi.Models;

namespace filmDunyasi.Pages.Admin.Director
{
    public class DeleteModel : PageModel
    {
        private readonly filmDunyasi.Data.ApplicationDbContext _context;

        public DeleteModel(filmDunyasi.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public filmDunyasi.Models.Director Director { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Director = await _context.Director
                .Include(d => d.Country).FirstOrDefaultAsync(m => m.ID == id);

            if (Director == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Director = await _context.Director.FindAsync(id);

            if (Director != null)
            {
                _context.Director.Remove(Director);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
