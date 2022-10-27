using CadastroDeContatos.Models;

namespace CadastroDeContatos.Repositório
{
    public interface IUsuarioRepositorio
    {

        UsuarioModel ListarPorId(int id);
        List<UsuarioModel> BuscarTodos();
        UsuarioModel Adicionar(UsuarioModel usuario);

        UsuarioModel Atualizar(UsuarioModel usuario);
        Boolean Apagar(int id);

        UsuarioModel BuscarPorLogin(string login);
        
    }
}
