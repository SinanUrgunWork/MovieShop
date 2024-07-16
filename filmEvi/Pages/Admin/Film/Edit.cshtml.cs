using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using filmDunyasi.Data;
using filmDunyasi.Models;
using Microsoft.AspNetCore.Hosting;
using System.IO;
using System;
using Microsoft.EntityFrameworkCore;

namespace filmDunyasi.Pages.Admin.Film
{
    public class EditModel : PageModel
    {
        private readonly filmDunyasi.Data.ApplicationDbContext _context;
        private readonly IWebHostEnvironment _hostingEnvironment;
        public EditModel(filmDunyasi.Data.ApplicationDbContext context, IWebHostEnvironment hostingEnvironment)
        {
            _context = context;
            _hostingEnvironment = hostingEnvironment;
        }

        [BindProperty]
        public filmDunyasi.Models.Film Film { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            string webRootPath = _hostingEnvironment.WebRootPath;
            var files = HttpContext.Request.Form.Files;

            if (!ModelState.IsValid)
            {
                return Page();
            }
            //*************************************
            //Edit Menu Item
            // var objFromDb = _unitOfWork.MenuItem.Get(MenuItemObj.MenuItem.Id);
            string _banner = Film.Banner;

            if (files.Count > 0)
            {
                string fileName = Guid.NewGuid().ToString();
                var uploads = Path.Combine(webRootPath, @"images\Film");
                var extension = Path.GetExtension(files[0].FileName);

                var imagePath = Path.Combine(webRootPath, _banner.TrimStart('\\'));

                if (System.IO.File.Exists(imagePath))
                {
                    System.IO.File.Delete(imagePath);
                }


                using (var fileStream = new FileStream(Path.Combine(uploads, fileName + extension), FileMode.Create))
                {
                    files[0].CopyTo(fileStream);
                }
                Film.Banner = @"\images\menuItems\" + fileName + extension;
            }
            else
            {
                Film.Banner = _banner;
            }
            //**********************


            //_context.Attach(Film).State = EntityState.Modified;

            //try
            //{
            //    await _context.SaveChangesAsync();
            //}
            //catch (DbUpdateConcurrencyException)
            //{
            //    if (!FilmExists(Film.ID))
            //    {
            //        return NotFound();
            //    }
            //    else
            //    {
            //        throw;
            //    }
            //}
            _context.Attach(Film).State = EntityState.Modified;

            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }

    }
}
