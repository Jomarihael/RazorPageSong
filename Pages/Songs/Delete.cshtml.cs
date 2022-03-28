#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPageSong.Data;
using RazorPageSong.Models;

namespace RazorPageSong.Pages.Songs
{
    public class DeleteModel : PageModel
    {
        private readonly RazorPageSong.Data.RazorPageSongContext _context;

        public DeleteModel(RazorPageSong.Data.RazorPageSongContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Hael Hael { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Hael = await _context.Hael.FirstOrDefaultAsync(m => m.ID == id);

            if (Hael == null)
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

            Hael = await _context.Hael.FindAsync(id);

            if (Hael != null)
            {
                _context.Hael.Remove(Hael);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
