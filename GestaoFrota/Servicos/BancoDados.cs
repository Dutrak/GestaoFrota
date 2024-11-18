using SQLite;

namespace GestaoFrota.Servicos
{
    public class BancoDados
    {
        private static SQLiteAsyncConnection? _database;

        public BancoDados()
        {
            _database ??= new SQLiteAsyncConnection(Constantes.CaminhoBd, Constantes.Flags);
        }

       
        public SQLiteAsyncConnection Conexao()
        {
            return _database!;
        }
    }
}
