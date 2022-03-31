using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HistoryPedia.ViewModels
{
    public class EditUsernameViewModel
    {
        [Required(ErrorMessage = "Username required")]
        [Display(Name = "Username")]
        public string UserName { get; set; }
    }
}
