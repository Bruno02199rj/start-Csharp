
using WebApplication1.Data;
using WebApplication1.Models;

namespace ControllerContato.Repositorio
{


    public class ContatoRepositorio : IContatoRepositorio
    {
        private readonly BancoContext _bancoContext;
        public ContatoRepositorio(BancoContext bancoContext)
        {
            _bancoContext = bancoContext;
        }
        public ContatoModel Adicionar(ContatoModel Contato)
        {
           //gravar no banco de dados
           _bancoContext.Contatos.Add(Contato);
            _bancoContext.SaveChanges();
            return Contato;
        }

        public List<ContatoModel> BuscarTodos()
        {
            throw new NotImplementedException();
        }
    }
}