using SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoFrota.Modelos
{
    public class Historico
    {
        private long id;
        private Veiculo? auto;
        private string placa;
        private Combustivel? tipoComb;
        private string nomeComb;
        private decimal valorTotal;
        private int kmFinal;
        private float litros;
        private DateTime data;

        public Veiculo? Auto { get => auto; set => auto = value; }
        public Combustivel? TipoComb { get => tipoComb; set => tipoComb = value; }
        public decimal ValorTotal { get => valorTotal; set => valorTotal = value; }
        public int KmFinal { get => kmFinal; set => kmFinal = value; }
        public float Litros { get => litros; set => litros = value; }

        [DataType(DataType.Date)]
        public DateTime Data { get => data; set => data = value; }

        [PrimaryKey]
        public long Id { get => id; set => id = value; }
        public string Placa { get => placa; set => placa = value; }
        public string NomeComb { get => nomeComb; set => nomeComb = value; }
    }
}
