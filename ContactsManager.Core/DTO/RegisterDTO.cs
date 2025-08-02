using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsManager.Core.DTO;

public class RegisterDTO
{
    [Required(ErrorMessage = "name can't be blank")]
    public string PersonName { get; set; }
    [Required(ErrorMessage = "Email can't be blank")]
    [EmailAddress(ErrorMessage = "email need be valid")]
    public string Email { get; set; }
    [Required(ErrorMessage = "phone can't be blank")]
    [RegularExpression("^[0-9]*$", ErrorMessage ="phone need be valid")]
    public string Phone { get; set; }
    [Required(ErrorMessage = "Password can't be blank")]
    [DataType(DataType.Password)]
    public string Password { get; set; }
    [Required(ErrorMessage = "confirm password can't be blank")]
    [DataType(DataType.Password)]
    public string ConfirmPassword { get; set; }
}

