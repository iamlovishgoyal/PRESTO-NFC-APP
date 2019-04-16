using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment4Games.Models
{
    interface IGamesRepository
    {
        IQueryable<Game> Games { get; }
    }
}
