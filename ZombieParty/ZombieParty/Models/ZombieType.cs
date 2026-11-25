using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace ZombieParty.Models
{
    public class ZombieType
    {
        public int Id { get; set; }

        [Display(Name = "TypeName")]
        [StringLength(25, MinimumLength = 5, ErrorMessage = "ValidationStringMinMax")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "ValidationRequired")]
        public string TypeName { get; set; }

        [Display(Name = "Point")]
        [Range(2, 5, ErrorMessage = "ValidationRange")]
        public int Point { get; set; }

        [Display(Name = "Zombies")]
        [ValidateNever]
        public virtual List<Zombie>? Zombies { get; set; }
    }
}
