using CadastroDeContatos.Models;
using CadastroDeContatos.Repositório;
using Microsoft.AspNetCore.Mvc;

namespace CadastroDeContatos.Controllers
{
    
   /// <summary>
   /// Essa Controller gerencia as views de Contato
   /// </summary>
    public class ContatoController : Controller
    {
        private readonly IContatoRepositorio _contatoRespositorio;

        public ContatoController(IContatoRepositorio contatoRepositorio)
        {
            _contatoRespositorio = contatoRepositorio;
        }

        public IActionResult Index()
        {
           List<ContatoModel> contatos = _contatoRespositorio.BuscarTodos();
            return View(contatos);
        }

        public IActionResult CriarContato()
        {
            return View();
        }

        /// <summary>
        /// Esse método lista no banco de dados o contato correspondente ao ID.
        /// </summary>
        /// <param name="id">Esse método recebe o ID do contato</param>
        /// <returns>O retorno desse método é o contato solicitado.</returns>
        public IActionResult EditarContato(int id)
        {
            ContatoModel contato = _contatoRespositorio.ListarPorId(id);
            return View(contato);
        }

        public IActionResult ApagarContatoConfirmacao(int id)
        {
            ContatoModel contato = _contatoRespositorio.ListarPorId(id);

            return View(contato);
        }

        [HttpDelete]
        public IActionResult Apagar(int id)
        {
           try
            {
                bool apagado = _contatoRespositorio.Apagar(id);

                if (apagado)
                {
                    TempData["MensagemSucesso"] = "Contato excluído com sucesso!";
                }
                else
                {
                    TempData["MensagemErro"] = $"Ops, não conseguimos excluir o seu contato";

                }

                return RedirectToAction("Index");
            }
            catch (Exception erro)
            {
                TempData["MensagemErro"] = $"Ops, não conseguimos excluir o seu contato, tente novamente. Detalhe do erro: {erro.Message}";
                return RedirectToAction("Index");
            }
        }


        [HttpPost]
        public IActionResult CriarContato(ContatoModel contato)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _contatoRespositorio.Adicionar(contato);
                    TempData["MensagemSucesso"] = "Contato cadastrado com sucesso!";
                    return RedirectToAction("Index");
                }

                return View(contato);
            }
            catch (Exception erro)
            {
                TempData["MensagemErro"] = $"Ops, não conseguimos cadastrar o seu contato, tente novamente. Detalhe do erro: {erro.Message}";
                return RedirectToAction("Index");
            }
            
        }

        [HttpPost]
        public IActionResult Alterar(ContatoModel contato)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _contatoRespositorio.Atualizar(contato);
                    TempData["MensagemSucesso"] = "Contato alterado com sucesso!";

                    return RedirectToAction("Index");

                }

                return View("EditarContato", contato); //Forçando a visualização da View Editar
            }
            catch (Exception erro) {

                TempData["MensagemErro"] = $"Ops, não conseguimos editar o seu contato, tente novamente. Detalhe do erro: {erro.Message}";
                return RedirectToAction("Index");
            }
        }

    }
}
