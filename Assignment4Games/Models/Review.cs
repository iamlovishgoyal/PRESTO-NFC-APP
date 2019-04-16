using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment4Games.Models
{
    public class Review
    {
        public int ReviewId { get; set; }
        public string UserName { get; set; }
        public string Comment { get; set; }
        public string GameId { get; set; }
        public DateTime Time { get; set; }
    }
}
