using GestaoFrota.Modelos;
using GestaoFrota.Servicos;
using SQLite;

namespace GestaoFrota.Repositorios
{
    public class HistoricoRepositorio : IRepositorio<Historico,long>
    {
        private readonly SQLiteAsyncConnection _conexao;

        public HistoricoRepositorio()
        {
            _conexao = new BancoDados().Conexao();
            _conexao.CreateTableAsync<Historico>();
        }

        public void atualizar(Historico objeto)
        {
           _ = _conexao.UpdateAsync(objeto).Result;
        }

        public Historico BuscaId(long chave)
        {
            return _conexao.Table<Historico>()
                            .Where(t => t.Id == chave)
                            .FirstOrDefaultAsync().Result;
        }

        public void Inserir(Historico objeto)
        {
            Task<int> r = _conexao.InsertAsync(objeto);
            
        }

        public void remover(Historico objeto)
        {
            _ = _conexao.DeleteAsync(objeto);
            
        }

        public List<Historico> Todos()
        {
            return _conexao.Table<Historico>().ToListAsync().Result;

        }
    }
}
