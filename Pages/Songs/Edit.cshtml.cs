#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RazorPageSong.Data;
using RazorPageSong.Models;

namespace RazorPageSong.Pages.Songs
{
    public class EditModel : PageModel
    {
        private readonly RazorPageSong.Data.RazorPageSongContext _context;

        public EditModel(RazorPageSong.Data.RazorPageSongContext context)
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

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Hael).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HaelExists(Hael.ID))
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

        private bool HaelExists(int id)
        {
            return _context.Hael.Any(e => e.ID == id);
        }
    }
}
