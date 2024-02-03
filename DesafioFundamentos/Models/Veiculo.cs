using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioFundamentos.Models
{
    internal class Veiculo
    {
        internal string Placa { get; set; }
        internal DateTime HoradeEntrada { get; set; }

        internal Veiculo(string placaVeiculo, DateTime horarioEntrada)
        {
            this.Placa = placaVeiculo;
            this.HoradeEntrada = horarioEntrada;
        }
    }
}
