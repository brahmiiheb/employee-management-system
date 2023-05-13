namespace CSharp_EmployeeCrud.Models{
public class RegisterModel
{
    
    public string? Username { get; set; }

    
    public string? Email { get; set; }

   
    public string? Password { get; set; }

    [System.ComponentModel.DataAnnotations.DataType(System.ComponentModel.DataAnnotations.DataType.Password)]
    [System.ComponentModel.DataAnnotations.Display(Name = "Confirm password")]
    [System.ComponentModel.DataAnnotations.Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
    public string? ConfirmPassword { get; set; }
        public string? ReturnUrl { get; internal set; }
    }
}






