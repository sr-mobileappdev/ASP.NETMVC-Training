﻿using System.ComponentModel.DataAnnotations;

namespace MedioClinic.Models.Account
{
    public class PasswordConfirmationViewModel : PasswordViewModel
    {
        [DataType(DataType.Password)]
        [Display(Name = "General.ConfirmPassword")]
        [Compare("Password", ErrorMessage = "ChangePassword.ErrorNewPassword")]
        public string ConfirmPassword { get; set; }
    }
}