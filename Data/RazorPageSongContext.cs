#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorPageSong.Models;

namespace RazorPageSong.Data
{
    public class RazorPageSongContext : DbContext
    {
        public RazorPageSongContext (DbContextOptions<RazorPageSongContext> options)
            : base(options)
        {
        }

        public DbSet<RazorPageSong.Models.Hael> Hael { get; set; }
    }
}
