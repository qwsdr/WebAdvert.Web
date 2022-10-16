using System.ComponentModel.DataAnnotations;

namespace WebAdvert.Web.Models.Account
{
    public class LoginModel
    {
        [Required]
        [EmailAddress]
        [Display(Name ="Email")]
        public string  Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name ="Password")]
        public string Password { get; set; }
        public bool RememberMe { get; set; }

    }
}
