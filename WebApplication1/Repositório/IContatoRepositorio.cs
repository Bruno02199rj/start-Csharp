
using WebApplication1.Models;

namespace ControllerContato.Repositorio
{


    public interface IContatoRepositorio
    {
        List<ContatoModel> BuscarTodos();
        ContatoModel Adicionar(ContatoModel Contato);
    }
}