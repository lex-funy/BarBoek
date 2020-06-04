using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BarboekMVC.Models
{
    public abstract class AddressModel
    {
        public int AID { get; set; }
        [Display(Name = "Street*")]
        [Required(ErrorMessage = "U moet de street invullen.")]
        public string Street { get; set; }
        [Display(Name = "Number*")]
        [Required(ErrorMessage = "U moet de number invullen.")]
        public int Number { get; set; }
        public string Addition { get; set; }
        [Display(Name = "Zipcode*")]
        [Required(ErrorMessage = "U moet de zipcode invullen.")]
        public string ZipCode { get; set; }
    }
}
