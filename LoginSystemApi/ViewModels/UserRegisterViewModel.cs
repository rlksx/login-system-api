using System.ComponentModel.DataAnnotations;

namespace LoginSystemApi.ViewModels;

public class UserRegisterViewModel
{
    [Required(ErrorMessage = "O campo nome é obrigatório!")]
    [StringLength(14, MinimumLength = 2, 
        ErrorMessage = "O campo deve ter entre 2 e 14 caracteres!")]
    public string Name { get; set; }
    
    [Required(ErrorMessage = "O campo password é obrigatório!")]
    [StringLength(35,MinimumLength = 4, 
        ErrorMessage = "O campo password deve conter entre 4 e 35 caracteres!")]
    public string Password { get; set; }
    
    [Required(ErrorMessage = "O campo password é obrigatório!")]
    public string Email { get; set; }

    public string Bio { get; set; } = "";
}