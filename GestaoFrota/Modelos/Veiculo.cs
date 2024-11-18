using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoFrota.Modelos
{
    public class Veiculo
    {
        private string placa;
        private string modelo;
        private int kmInicial;
        private int KmFinal;
        private float cilindrada;
        private float potencia;

        [PrimaryKey]
        public string Placa { get => placa; set => placa = value; }
        public string Modelo { get => modelo; set => modelo = value; }
        public int KmInicial { get => kmInicial; set => kmInicial = value; }
        public int KmFinal1 { get => KmFinal; set => KmFinal = value; }
        public float Cilindrada { get => cilindrada; set => cilindrada = value; }
        public float Potencia { get => potencia; set => potencia = value; }
    }
}
