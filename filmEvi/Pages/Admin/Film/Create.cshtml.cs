using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using filmDunyasi.Data;
using filmDunyasi.Models;
using Microsoft.AspNetCore.Hosting;
using System.IO;

namespace filmDunyasi.Pages.Admin.Film
{
    public class CreateModel : PageModel
    {
        private readonly filmDunyasi.Data.ApplicationDbContext _context;
        private readonly IWebHostEnvironment _hostingEnvironment;
        public CreateModel(filmDunyasi.Data.ApplicationDbContext context, IWebHostEnvironment hostingEnvironment)
        {
            _context = context;
            _hostingEnvironment = hostingEnvironment;
        }

        public IActionResult OnGet()
        {
            ViewData["CategoryID"] = new SelectList(_context.Category, "ID", "Name");
            ViewData["DirectorID"] = new SelectList(_context.Director, "ID", "FullName");
            ViewData["NativeID"] = new SelectList(_context.Native, "ID", "Name");
            return Page();
        }

        [BindProperty]
        public filmDunyasi.Models.Film Film { get; set; }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            string webRootPath = _hostingEnvironment.WebRootPath;
            var files = HttpContext.Request.Form.Files;

            if (!ModelState.IsValid)
            {
                return Page();
            }
            string fileName = Guid.NewGuid().ToString();
            var uploads = Path.Combine(webRootPath, @"images\Film");
            var extension = Path.GetExtension(files[0].FileName);

            using (var fileStream = new FileStream(Path.Combine(uploads, fileName + extension), FileMode.Create))
            {
                files[0].CopyTo(fileStream);
            }
            Film.Banner = @"\images\Film\" + fileName + extension;

            _context.Film.Add(Film);

            await _context.SaveChangesAsync();
            return RedirectToPage("./Index");
        }
    }
}
