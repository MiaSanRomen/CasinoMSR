using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CasinoMSR.Web.Models;
using CasinoMSR.Web.ViewModels;

namespace CasinoMSR.Web.ViewModels
{
    public class PlayGameViewModel : BaseViewModel
    {
        public int CurrentBid { get; set; }
    }
}
