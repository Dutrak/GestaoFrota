namespace GestaoFrota.Repositorios
{
    public interface IRepositorio<T,K>
    {   public  List<T> Todos();

        public T BuscaId(K chave);

        public void Inserir(T objeto);

        public void atualizar(T objeto);

        public void remover(T objeto);
    }
}
