using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioFundamentos.Models
{
    public class IUser
    {
        public static void ExibirMenu()
        {
            string? placaDoCarro;
            Estacionamento estacionamento = new Estacionamento();

            do
            {
                Console.Clear();
                Console.WriteLine("SEJA BEM-VINDO AO SISTEMA DE ESTACIONAMENTO!");
                Console.WriteLine("____________________________________________");
                Console.WriteLine("O que você deseja fazer?");
                Console.WriteLine("1-Ajustar o valor inicial");
                Console.WriteLine("2-Ajustar o valor da hora");
                Console.WriteLine("3-Receber carro");
                Console.WriteLine("4-Devolver carro");
                Console.WriteLine("5-Mostrar lista de carros estacionados");
                Console.WriteLine("OU DIGITE QUALQUER OUTRA TECLA PARA SAIR DO SISTEMA");

                if (int.TryParse(Console.ReadLine(), out int option))
                {
                    switch (option)
                    {
                        case 1:
                            Console.WriteLine("Qual o novo valor inicial?");
                            if (float.TryParse(Console.ReadLine(), out float valorInicial))
                                estacionamento.AjustarInicio(valorInicial);
                            Console.ReadLine();
                            break;
                        case 2:
                            Console.WriteLine("Qual o novo valor da hora?");
                            if (float.TryParse(Console.ReadLine(), out float valorHora))
                                estacionamento.AjustarHora(valorHora);
                            Console.ReadLine();
                            break;
                        case 3:
                            Console.WriteLine("Digite a placa do carro:");
                            placaDoCarro = Console.ReadLine();
                            estacionamento.AdicionarVeiculo(placaDoCarro);
                            Console.ReadLine();
                            break;
                        case 4:
                            Console.WriteLine("Digite a placa do carro:");
                            placaDoCarro = Console.ReadLine();
                            Console.WriteLine(estacionamento.RemoverVeiculo(placaDoCarro));
                            Console.ReadLine();
                            break;

                        case 5:
                            Console.WriteLine("Lista de veículos estacionados:");
                            List<string> veiculosEstacioandos = estacionamento.ListarVeiculos();
                            foreach (string placa in veiculosEstacioandos)
                            {
                                Console.WriteLine(placa);
                            }
                            Console.ReadLine();
                            break;

                        default:
                            Environment.Exit(0);
                            break;
                    }
                }
            }while(true);
        }
    }
}
