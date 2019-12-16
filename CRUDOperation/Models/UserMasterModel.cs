using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CRUDOperation.Models
{
    public class UserMasterModel
    {
        [Required(ErrorMessage = "UserName is required.")]
        [Display(Name = "User Name")]
        public string UserName { get; set; }
        [Display(Name = "User Type")]
        public string UserType { get; set; }
        [Display(Name = "Full Name")]
        public string FullName { get; set; }
        public string Email { get; set; }
        [Display(Name = "Contact No")]
        public string ContactNo { get; set; }
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        [Required(ErrorMessage = "Password is required.")]
        [StringLength(50, ErrorMessage = "Password cannot be longer than 50 characters.")]
        public string Password { get; set; }
        [DataType(DataType.Password)]
        [Display(Name = "Re Type Password")]
        [Required(ErrorMessage = "Password is required.")]
        [StringLength(50, ErrorMessage = "Password cannot be longer than 50 characters.")]
        public string ReTypePassword { get; set; }
    }
}