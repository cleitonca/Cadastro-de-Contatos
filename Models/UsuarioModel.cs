using CadastroDeContatos.Enums;
using System.ComponentModel.DataAnnotations;

namespace CadastroDeContatos.Models
{
    public class UsuarioModel
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

        [Required(ErrorMessage = "Digite a senha do Usuário!")]
        [DataType(DataType.Password)]
        [Display(Name = "Senha")]
        public string Senha { get; set; }

        [Required(ErrorMessage = "Informe o perfil do Usuário!")]
        public PerfilEnum? Perfil { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime DataCadastro { get; set; }

        public DateTime? DataAtualizacao { get; set; }

        public bool SenhaValida(string senha)
        {
            return Senha == senha;
        }

    }
}
