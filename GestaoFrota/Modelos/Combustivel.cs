using SQLite;

namespace GestaoFrota.Modelos
{
    public class Combustivel
    {

        private string tipo;
        private decimal valorLitro;

        [PrimaryKey]
        [NotNull]
        public string Tipo { get => tipo; set => tipo = value; }
        public decimal ValorLitro { get => valorLitro; set => valorLitro = value; }
    }
}
