using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment4Games.Models
{
    public class GroupedGame
    {
       
        //This is for Data model.
      
        public string GroupName { get; set; }
        public List<Game> Games { get; set; }
    }
}
