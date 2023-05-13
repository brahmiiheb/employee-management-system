namespace CSharp_EmployeeCrud.Models{
public class LoginModel
{
    
    public string? Username { get; set; }
     public string? Email { get; set; }

    
    [System.ComponentModel.DataAnnotations.DataType(System.ComponentModel.DataAnnotations.DataType.Password)]
    public string? Password { get; set; }

    [System.ComponentModel.DataAnnotations.Display(Name = "Remember me?")]
    public bool RememberMe { get; set; }
        public string? ReturnUrl { get; internal set; }
    }
}