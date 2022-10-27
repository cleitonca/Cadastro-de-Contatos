using CadastroDeContatos.Models;

namespace CadastroDeContatos.Repositório
{
    public interface IContatoRepositorio
    {

        ContatoModel ListarPorId(int id);
        List<ContatoModel> BuscarTodos();
        ContatoModel Adicionar(ContatoModel contato);

        ContatoModel Atualizar(ContatoModel contato);
        Boolean Apagar(int id);
    }
}
