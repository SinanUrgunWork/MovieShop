using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using filmDunyasi.Data;
using filmDunyasi.Models;

namespace filmDunyasi.Pages.Admin.Native
{
    public class EditModel : PageModel
    {
        private readonly filmDunyasi.Data.ApplicationDbContext _context;

        public EditModel(filmDunyasi.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public filmDunyasi.Models.Native Native { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Native = await _context.Native.FirstOrDefaultAsync(m => m.ID == id);

            if (Native == null)
            {
                return NotFound();
            }
            return Page();
        }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Native).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!NativeExists(Native.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool NativeExists(int id)
        {
            return _context.Native.Any(e => e.ID == id);
        }
    }
}
