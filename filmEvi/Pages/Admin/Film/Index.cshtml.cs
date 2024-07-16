using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using filmDunyasi.Data;
using filmDunyasi.Models;

namespace filmDunyasi.Pages.Admin.Film
{
    public class IndexModel : PageModel
    {
        private readonly filmDunyasi.Data.ApplicationDbContext _context;

        public IndexModel(filmDunyasi.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<filmDunyasi.Models.Film> Film { get;set; }

        public async Task OnGetAsync()
        {
            Film = await _context.Film
                .Include(f => f.Category)
                .Include(f => f.Director)
                .Include(f => f.Native).ToListAsync();
        }
    }
}
