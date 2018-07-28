using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
namespace RRSBOL
{
    public class Users : UserLogin
    {
        [Key]
        public int Id { set; get; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Password field is required")]
        [DataType(DataType.Password)]
        [StringLength(25, MinimumLength = 8, ErrorMessage = "The minimum lenght of the pssword is 8 and the maximum lenght of the password is 25")]
        public string ConfirmPassword { set; get; }
     
        [Required(AllowEmptyStrings=false,ErrorMessage="First name is required field")]
        [StringLength(50,ErrorMessage="This field not expect more then 50 charachter")]
        public string Firstname { set; get; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Last name is required field")]
        [StringLength(50, ErrorMessage = "This field not expect more then 50 charachter")]
        public string Lastname { set; get; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Gender is required field")]
        [StringLength(50, ErrorMessage = "This field not expect more then 50 charachter")]
        public string Gender { set; get; }
      
        public int IsActive { set; get; }
        public string UserImage { set; get; }
        public int RuleId { set; get; }
        public Guid ActivationCode { set; get; }
    }
}
