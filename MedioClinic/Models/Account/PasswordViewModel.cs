﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

using MedioClinic.Utils;

namespace MedioClinic.Models.Account
{
    public class PasswordViewModel : IViewModel
    {
        [Required]
        [DataType(DataType.Password)]
        [DisplayName("Models.Account.Password")]
        [MaxLength(100, ErrorMessage = "Models.MaxLength")]
        public string Password { get; set; }
    }
}