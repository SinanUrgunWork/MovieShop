using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using filmDunyasi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace filmDunyasi.Pages.Customer.Home
{
    public class IndexModel : PageModel
    {
        private readonly filmDunyasi.Data.ApplicationDbContext _db;
        public IndexModel(filmDunyasi.Data.ApplicationDbContext db)
        {
            _db = db;
        }

        
        public List<Film> yakinda { get; set; }
        
    }
}