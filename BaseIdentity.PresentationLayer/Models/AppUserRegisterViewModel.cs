using System;
using System.ComponentModel.DataAnnotations;

namespace BaseIdentity.PresentationLayer.Models
{
    public class AppUserRegisterViewModel
    {
        [Required(ErrorMessage = "User name can not left blank!")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Name can not left blank!")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Surname can not left blank!")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "Mail can not left blank!")]
        public string Mail { get; set; }

        [Required(ErrorMessage = "Password can not left blank!")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Password can not left blank!")]
        public string ConfirmPassword { get; set; }

    }
}
