using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment4Games.Models
{
    public class Game
    {
        [Key]
        public string GameId { get; set; }

        public string GameName { get; set; }

        public string Genre { get; set; }

        public string Developer { get; set; }

        public string Platform { get; set; }

        public string Languages { get; set; }

        public int Rating { get; set; }

        public string Description { get; set; }
    }
}
