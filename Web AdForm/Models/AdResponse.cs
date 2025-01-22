using System.ComponentModel.DataAnnotations;

namespace Web_AdForm.Models
{
    public class AdResponse
    {

        [Required(ErrorMessage = "Please share your email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please write me a message")]
        public string Message { get; set; }
    }
}
