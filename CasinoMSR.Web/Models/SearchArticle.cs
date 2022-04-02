using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CasinoMSR.Web.Models
{
    public class SearchGame
    {
        public List<User> Users { get; set; }
        public User CurrentUser { get; set; }
        public List<Game> Games { get; set; }
    }
}
