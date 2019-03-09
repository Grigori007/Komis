using System.ComponentModel.DataAnnotations;

namespace Komis.ViewModels
{
    public class LoginViewModel
    {
        [Required]
        [Display(Name ="User name")]
        public string UserName { get; set; }

        [Required]
        [Display(Name ="Password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
