using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using filmDunyasi.Data;
using filmDunyasi.Models;

namespace filmDunyasi.Pages.Admin.Native
{
    public class IndexModel : PageModel
    {
        private readonly filmDunyasi.Data.ApplicationDbContext _context;

        public IndexModel(filmDunyasi.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<filmDunyasi.Models.Native> Native { get;set; }

        public async Task OnGetAsync()
        {
            Native = await _context.Native.ToListAsync();
        }
    }
}
