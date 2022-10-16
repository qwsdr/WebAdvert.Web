using System.ComponentModel.DataAnnotations;

namespace WebAdvert.Web.Models.Account
{
    public class ConfirmModel
    {
        [Required]
        [EmailAddress]
        [Display(Name ="Email")]
        public string Email { get; set; }
        [Required]
        public string Code { get; set; }

    }
}
