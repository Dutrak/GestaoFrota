using GestaoFrota.Modelos;
using GestaoFrota.Servicos;
using SQLite;

namespace GestaoFrota.Repositorios
{
    public class VeiculoRepositorio : IRepositorio<Veiculo,string>
    {
        private readonly SQLiteAsyncConnection _conexao;

        public VeiculoRepositorio()
        {
            _conexao = new BancoDados().Conexao();
            _conexao.CreateTableAsync<Veiculo>();
        }

        public void atualizar(Veiculo objeto)
        {
            _conexao.UpdateAsync(objeto);
        }

        public Veiculo BuscaId(string chave)
        {
            return _conexao.FindAsync<Veiculo>(chave).Result;
        }

        public void Inserir(Veiculo objeto)
        {
            _conexao.InsertAsync(objeto);
        }

        public void remover(Veiculo objeto)
        {
            _conexao.DeleteAsync(objeto);
        }

        public List<Veiculo> Todos()
        {
            return _conexao.Table<Veiculo>().ToListAsync().Result;
        }
    }
}
