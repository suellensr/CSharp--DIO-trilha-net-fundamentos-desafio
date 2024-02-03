using System;
using System.Numerics;

namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private float precoInicial = 5.00f;
        private float precoPorHora = 3.00f;
        //private List<Veiculo> veiculos = new List<Veiculo>();
        private List<Veiculo> veiculos = new List<Veiculo>
        {
            new Veiculo("ABC1234", DateTime.Now.AddHours(-1)),
            new Veiculo("DEF5678", DateTime.Now.AddHours(-2)),
            new Veiculo("GHI9876", DateTime.Now.AddHours(-3))
        };

        public void AjustarInicio(float valorInicial)
        {
            this.precoInicial = valorInicial;
        }

        public void AjustarHora(float valorHora)
        {
            this.precoInicial = valorHora;
        }

        public void AdicionarVeiculo(string placaVeiculo)
        {
            Veiculo veiculo = new Veiculo(placaVeiculo, DateTime.Now);
            veiculos.Add(veiculo);
        }

        public string RemoverVeiculo(string placaVeiculo)
        {
            // Verifica se o veículo existe e obtém a hora de entrada
            var veiculoEncontrado = veiculos.FirstOrDefault(x => x.Placa.ToUpper() == placaVeiculo.ToUpper());

            if (veiculoEncontrado != null)
            {
                DateTime horaDeEntrada = veiculoEncontrado.HoradeEntrada;
                DateTime horaDeSaida = DateTime.Now;
                float tempoEstacionado= (float)horaDeSaida.Subtract(horaDeEntrada).TotalMinutes/60;
                float valorTotal = precoInicial;
                valorTotal = precoInicial + (tempoEstacionado * precoPorHora);

                return $"O veículo {veiculoEncontrado.Placa} foi liberado e o preço total a pagar é de : R$ {valorTotal:F2}";
            }
            else
                return $"Não existe nenhum veiculo com a placa {placaVeiculo} neste estacionamento";
        }

        public List<string> ListarVeiculos()
        {
            if (veiculos.Any())
            {
                List<string> veiculosEstacionados = new List<string>();
                foreach (var veiculo in veiculos)
                {
                    veiculosEstacionados.Add(veiculo.Placa);
                }
                return veiculosEstacionados;
            }
            else
                return new List<string> {"Não há nenhum veículo estacionado no momento!"};
        }
    }
}
