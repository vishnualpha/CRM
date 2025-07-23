using System.ComponentModel.DataAnnotations;

namespace CRM.Models
{
    public class LoginModel
    {
        //This is something to be done
        [Required(ErrorMessage = "Please Enter User Name")]
        [Display(Name = "Login")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Please Enter Password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
