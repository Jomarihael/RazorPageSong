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
#pragma warning disable
#pragma warning disable


    public class IndexModel : PageModel
    {
        private readonly RazorPageSong.Data.RazorPageSongContext _context;

        public IndexModel(RazorPageSong.Data.RazorPageSongContext context)
        {
            _context = context;
        }

        public IList<Hael> Hael { get;set; }

        public async Task OnGetAsync()
        {
            Hael = await _context.Hael.ToListAsync();
        }
#pragma warning restore
#pragma warning restore
    }
}
