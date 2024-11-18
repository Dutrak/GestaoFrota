using GestaoFrota.Modelos;
using GestaoFrota.Servicos;
using SQLite;

namespace GestaoFrota.Repositorios
{
    public class CombustivelRepositorio : IRepositorio<Combustivel, string>
    {
        private readonly SQLiteAsyncConnection _conexao;

        public CombustivelRepositorio()
        {
            _conexao = new BancoDados().Conexao();
            _conexao.CreateTableAsync<Combustivel>();
        }

        public void atualizar(Combustivel objeto)
        {
            _conexao.UpdateAsync(objeto);
        }

        public Combustivel BuscaId(string chave)
        {
            return _conexao.FindAsync<Combustivel>(chave).Result;
        }

        public void Inserir(Combustivel objeto)
        {
            _conexao.InsertAsync(objeto);
        }

        public void remover(Combustivel objeto)
        {
            _conexao.DeleteAsync(objeto);
        }

        public List<Combustivel> Todos()
        {
            return _conexao.Table<Combustivel>().ToListAsync().Result;
        }
    }
}
