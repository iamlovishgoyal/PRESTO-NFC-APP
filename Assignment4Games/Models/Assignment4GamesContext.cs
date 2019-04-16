using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Assignment4Games.Models;

namespace Assignment4Games.Models
{
    public class Assignment4GamesContext : DbContext
    {
        public Assignment4GamesContext (DbContextOptions<Assignment4GamesContext> options)
            : base(options)
        {
        }

        public DbSet<Assignment4Games.Models.Game> Games { get; set; }

        public DbSet<Assignment4Games.Models.Review> Review { get; set; }
        public DbSet<Assignment4Games.Models.Payment> Payment { get; set; }
    }
}
