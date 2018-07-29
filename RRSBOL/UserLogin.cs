using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace RRSBOL
{
    public class UserLogin
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "Email id is a requird field")]
        [DataType(DataType.EmailAddress)]
        [Remote("isEmailExist", "Users", "Users", HttpMethod = "Post", ErrorMessage = "Email Address is already exist")]
        public string Email { set; get; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Password field is required")]
        [DataType(DataType.Password)]
        [StringLength(25, MinimumLength = 8, ErrorMessage = "The minimum lenght of the pssword is 8 and the maximum lenght of the password is 25")]
        public string Password { set; get; }

    }
}
