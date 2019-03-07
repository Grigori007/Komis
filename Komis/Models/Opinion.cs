using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.ComponentModel.DataAnnotations;

namespace Komis.Models
{
    public class Opinion
    {
        [BindNever]
        public int Id { get; set; }

        [Required(ErrorMessage = "Username is required!")]
        [StringLength(100, ErrorMessage = "Username is too long!")]
        public  string UserName { get; set; }

        [Required(ErrorMessage = "Email is required!")]
        [StringLength(100, ErrorMessage ="Email is too long!")]
        [DataType(DataType.EmailAddress)]
        [RegularExpression(@"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$", ErrorMessage ="Invalid email!")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Message is required!")]
        [StringLength(1000, ErrorMessage = "Message is too long!")]
        public string Message { get; set; }

        public bool WaitingForResponse { get; set; }
    }
}
