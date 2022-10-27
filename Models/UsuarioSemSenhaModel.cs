using CadastroDeContatos.Enums;
using System.ComponentModel.DataAnnotations;

namespace CadastroDeContatos.Models
{
    public class UsuarioSemSenhaModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Digite o nome do Usuário!", AllowEmptyStrings = false)]
        [DataType(DataType.Text)]
        [Display(Name = "Nome")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Digite o login do Usuário!")]
        [DataType(DataType.Text)]
        [Display(Name = "Login")]
        public string Login { get; set; }

        [Required(ErrorMessage = "Digite o Email do Usuário!")]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage = "Informe um email válido!")]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "E-mail")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Informe o perfil do Usuário!")]
        public PerfilEnum? Perfil { get; set; }

    }
}
