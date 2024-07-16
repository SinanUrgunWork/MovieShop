using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using filmDunyasi.Data;
using filmDunyasi.Models;

namespace filmDunyasi.Pages.Admin.Country
{
    public class DetailsModel : PageModel
    {
        private readonly filmDunyasi.Data.ApplicationDbContext _context;

        public DetailsModel(filmDunyasi.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public filmDunyasi.Models.Country Country { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Country = await _context.Country.FirstOrDefaultAsync(m => m.ID == id);

            if (Country == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
