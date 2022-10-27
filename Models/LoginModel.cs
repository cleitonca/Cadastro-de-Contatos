using System.ComponentModel.DataAnnotations;

namespace CadastroDeContatos.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Digite o login!")]
        [Display(Name = "Login")]
        public string Login { get; set; }

        [Required(ErrorMessage = "Digite a senha!")]
        [DataType(DataType.Password)]
        [Display(Name = "Senha")]
        public string Senha { get; set; }
    }
}
